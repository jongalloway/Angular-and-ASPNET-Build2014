/// <reference path="typings/jquery/jquery.d.ts" />
/// <reference path="typings/angularjs/angular.d.ts" />
/// <reference path="typings/signalr/signalr.d.ts" />

interface IPokerRoomClient {
	userChanged(user: Consensus.PokerUser);
	userRemoved(user: Consensus.PokerUser);

	resetRoom(room: Consensus.PokerRoom);
	showAllCards(show: boolean);
	roomTopicChanged(topic: string);
	cardChanged(card: Consensus.PokerCard);
}

interface IPokerRoomServer {
	join(user: Consensus.PokerUser): JQueryPromise;
	joinRoom(room: Consensus.PokerRoom): JQueryPromise;
	leaveRoom(room: Consensus.PokerRoom, user: Consensus.PokerUser): JQueryPromise;

	resetRoom(room: Consensus.PokerRoom): JQueryPromise;
	showAllCards(room: Consensus.PokerRoom, show: boolean): JQueryPromise;
	changeRoomTopic(room: Consensus.PokerRoom, topic: string): JQueryPromise;
	changedCard(room: Consensus.PokerRoom, value: string): JQueryPromise;
}

interface HubProxy {
	client: IPokerRoomClient;
	server: IPokerRoomServer;
}

interface SignalR {
	poker: HubProxy;
}

module Consensus {
	
	var app = angular.module("consensus", ["ngCookies", "ui.bootstrap"]);

	export interface IPokerRoomScope extends ng.IScope {
		joinModalOptions: Object;

		joinModal: bool;
		closeJoinModal();

		joinRoomModal: bool;
		closeJoinRoomModal();

		removeRoomUser();
		myCardValueChanged();
		roomTopicChanged();
		resetRoom();
		showAllCards(show: boolean);

		allCardsShowing: bool;

		me: PokerUser;
		room: PokerRoom;
		myCard: PokerCard;
	}

	export class PokerRoomCtrl {
		private _poker: HubProxy;
		
		// protect the injection from minification
		static $inject = ['$scope', '$location', '$cookies'];

		constructor(private $scope: IPokerRoomScope, private $location: ng.ILocationService, private $cookies: any) {
			this._poker = $.connection.poker;
			var that = this;

			$scope.$watch("room.Name", function (value) {
				if (!value) return;
				$location.path("/rooms/" + encodeURIComponent(value));
			});
			$scope.$watch("me.Email", function (value) {
				if (!value) return;
				$cookies.userEmail = value;
			});
			$scope.$watch("me.Name", function (value) {
				if (!value) return;
				$cookies.userName = value;
			});

			$scope.allCardsShowing = false;

			$scope.myCardValueChanged = function () {
				that.changedMyCardValue($scope.myCard.Value);
			};

			$scope.roomTopicChanged = function () {
				that.changeRoomTopic($scope.room.Topic);
			};

			$scope.closeJoinModal = function () {
				$scope.joinModal = !$scope.me.Name || !$scope.me.Email;
				$scope.joinRoomModal = !$scope.joinModal && !that.room;

				if (!$scope.joinModal) {
					that.join();
				}

				if (!$scope.joinRoomModal) {
					that.joinRoom();
				}
			};

			$scope.closeJoinRoomModal = function () {
				$scope.joinRoomModal = !$scope.room.Name;

				if (!$scope.joinRoomModal) {
					that.joinRoom();
				}
			};

			$scope.removeRoomUser = function () {
				that.leaveRoom(this.user);
			};

			$scope.resetRoom = function () {
				that.resetRoom();
			};

			$scope.showAllCards = function (show: boolean) {
				that.showAllCards(show);
			};

			$scope.joinModalOptions = {
				backdrop: false,
				backdropClick: false
			};

			this._poker.client.userChanged = (user: PokerUser) => this.userChanged(user);
			this._poker.client.userRemoved = (user: PokerUser) => this.userRemoved(user);
			this._poker.client.cardChanged = (card: PokerCard) => this.cardChanged(card);
			this._poker.client.roomTopicChanged = (topic: string) => {
				$scope.room.Topic = topic;
				$scope.$apply();
			};
			this._poker.client.showAllCards = (show: boolean) => {
				$scope.allCardsShowing = show;
				$scope.$apply();
			};
			this._poker.client.resetRoom = (room: PokerRoom) => {
				$scope.room = room;
				$scope.myCard.Value = "";
				$scope.$apply();
			};

			$.connection.hub.start().done(function () {
				if (that.me) {
					that.join().done(function () {
						if (that.room) {
							that.joinRoom();
						} else {
							$scope.joinRoomModal = true;
							$scope.$apply();
						}
					});
				} else {
					$scope.joinModal = true;
					$scope.$apply();
				}
			});
		}

		get myCard(): PokerCard {
			var value = this.$scope.myCard;

			if (!value) {
				var userEmail = this.$cookies.userEmail;
				var userName = this.$cookies.userName;

				if (!userEmail)
					return null;

				value = new PokerCard();
				value.User = this.me;
				value.Value = "";
			}

			return value;
		}

		get me(): PokerUser {
			var value = this.$scope.me;

			if (!value) {
				var userEmail = this.$cookies.userEmail;
				var userName = this.$cookies.userName;

				if (!userEmail)
					return null;

				value = new PokerUser();
				value.Name = userName;
				value.Email = userEmail;
			}

			return value;
		}

		get room(): PokerRoom {
			var value = this.$scope.room;

			if (!value) {
				var roomName = this.$location.path().replace("/rooms/", "");

				if (!roomName)
					return null;

				value = new PokerRoom();
				value.Name = roomName;

				this.$scope.room = value;
			}

			return value;
		}

		//#region Client

		private userChanged(user: PokerUser) {
			if (this.$scope.room.Users) {
				var found = false;

				this.$scope.room.Users = this.$scope.room.Users.map(function (roomUser) {
					if (user.Email === roomUser.Email) {
						found = true;
						roomUser = user;
					}

					return roomUser;
				});

				if (!found)
					this.$scope.room.Users.push(user);

				this.$scope.$apply();
			}
		}

		private userRemoved(user: PokerUser) {
			var found = false;

			if (user.Email === this.$scope.me.Email) {
				this.$scope.room = null;
				this.$scope.myCard = null;
				this.$location.path("");
				this.$scope.joinRoomModal = true;
			} else {
				this.$scope.room.Users = this.$scope.room.Users.filter(function (roomUser) {
					return user.Email !== roomUser.Email;
				});
				this.$scope.room.Cards = this.$scope.room.Cards.filter(function (roomCard) {
					return user.Email !== roomCard.User.Email;
				});
			}

			this.$scope.$apply();
		}

		private cardChanged(card: PokerCard) {
			if (this.$scope.room.Cards) {
				var found = false;

				this.$scope.room.Cards = this.$scope.room.Cards.map(function (roomCard) {
					if (card.User.Email === roomCard.User.Email) {
						found = true;
						roomCard = card;
					}

					return roomCard;
				});

				if (!found)
					this.$scope.room.Cards.push(card);

				this.$scope.$apply();
			}
		}

		//#endregion

		//#region Server

		private join(user: PokerUser = this.me): JQueryPromise {
			var that = this;
			return this._poker.server.join(user).done(function (data) {
				that.$scope.me = data;
				that.$scope.$apply();
			});
		}

		private joinRoom(room: PokerRoom = this.room) : JQueryPromise {
			this.$location.path("/rooms/" + encodeURIComponent(room.Name));

			var that = this;
			return this._poker.server.joinRoom(room).done(function (data) {
				that.$scope.room = data;

				var me = that.me;
				data.Cards.forEach(function (card) {
					if (card.User.Email === me.Email)
						that.$scope.myCard = card;
				});

				that.$scope.$apply();
			});
		}

		private leaveRoom(user: PokerUser = this.me): JQueryPromise {
			return this._poker.server.leaveRoom(this.room, user);
		}

		private resetRoom(): JQueryPromise {
			return this._poker.server.resetRoom(this.room);
		}

		private showAllCards(show: boolean = true): JQueryPromise {
			return this._poker.server.showAllCards(this.room, show);
		}

		private changeRoomTopic(topic: string): JQueryPromise {
			return this._poker.server.changeRoomTopic(this.room, topic);
		}

		private changedMyCardValue(value: string): JQueryPromise {
			return this._poker.server.changedCard(this.room, value);
		}

		//#endregion
	}

	// setup controller
	app.controller("PokerRoomCtrl", PokerRoomCtrl);

	export class PokerUser {
		public Name: string;
		public Email: string;
		public Disconnected: string;
	}

	export class PokerRoom {
		public Name: string;
		public Topic: string;
		public Users: PokerUser[];
		public Cards: PokerCard[];
	}

	export class PokerCard {
		public User: PokerUser;
		public Value: string;
	}
}