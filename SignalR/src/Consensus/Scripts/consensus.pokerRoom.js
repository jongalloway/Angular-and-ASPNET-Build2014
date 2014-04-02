var Consensus;
(function (Consensus) {
    var app = angular.module("consensus", ["ngCookies", "ui.bootstrap"]);

    var PokerRoomCtrl = (function () {
        function PokerRoomCtrl($scope, $location, $cookies) {
            var _this = this;
            this.$scope = $scope;
            this.$location = $location;
            this.$cookies = $cookies;
            this._poker = $.connection.poker;
            var that = this;

            $scope.$watch("room.Name", function (value) {
                if (!value)
                    return;
                $location.path("/rooms/" + encodeURIComponent(value));
            });
            $scope.$watch("me.Email", function (value) {
                if (!value)
                    return;
                $cookies.userEmail = value;
            });
            $scope.$watch("me.Name", function (value) {
                if (!value)
                    return;
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

            $scope.showAllCards = function (show) {
                that.showAllCards(show);
            };

            $scope.joinModalOptions = {
                backdrop: false,
                backdropClick: false
            };

            this._poker.client.userChanged = function (user) {
                return _this.userChanged(user);
            };
            this._poker.client.userRemoved = function (user) {
                return _this.userRemoved(user);
            };
            this._poker.client.cardChanged = function (card) {
                return _this.cardChanged(card);
            };
            this._poker.client.roomTopicChanged = function (topic) {
                $scope.room.Topic = topic;
                $scope.$apply();
            };
            this._poker.client.showAllCards = function (show) {
                $scope.allCardsShowing = show;
                $scope.$apply();
            };
            this._poker.client.resetRoom = function (room) {
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
        Object.defineProperty(PokerRoomCtrl.prototype, "myCard", {
            get: function () {
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
            },
            enumerable: true,
            configurable: true
        });

        Object.defineProperty(PokerRoomCtrl.prototype, "me", {
            get: function () {
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
            },
            enumerable: true,
            configurable: true
        });

        Object.defineProperty(PokerRoomCtrl.prototype, "room", {
            get: function () {
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
            },
            enumerable: true,
            configurable: true
        });

        PokerRoomCtrl.prototype.userChanged = function (user) {
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
        };

        PokerRoomCtrl.prototype.userRemoved = function (user) {
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
        };

        PokerRoomCtrl.prototype.cardChanged = function (card) {
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
        };

        PokerRoomCtrl.prototype.join = function (user) {
            if (typeof user === "undefined") { user = this.me; }
            var that = this;
            return this._poker.server.join(user).done(function (data) {
                that.$scope.me = data;
                that.$scope.$apply();
            });
        };

        PokerRoomCtrl.prototype.joinRoom = function (room) {
            if (typeof room === "undefined") { room = this.room; }
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
        };

        PokerRoomCtrl.prototype.leaveRoom = function (user) {
            if (typeof user === "undefined") { user = this.me; }
            return this._poker.server.leaveRoom(this.room, user);
        };

        PokerRoomCtrl.prototype.resetRoom = function () {
            return this._poker.server.resetRoom(this.room);
        };

        PokerRoomCtrl.prototype.showAllCards = function (show) {
            if (typeof show === "undefined") { show = true; }
            return this._poker.server.showAllCards(this.room, show);
        };

        PokerRoomCtrl.prototype.changeRoomTopic = function (topic) {
            return this._poker.server.changeRoomTopic(this.room, topic);
        };

        PokerRoomCtrl.prototype.changedMyCardValue = function (value) {
            return this._poker.server.changedCard(this.room, value);
        };
        PokerRoomCtrl.$inject = ['$scope', '$location', '$cookies'];
        return PokerRoomCtrl;
    })();
    Consensus.PokerRoomCtrl = PokerRoomCtrl;

    app.controller("PokerRoomCtrl", PokerRoomCtrl);

    var PokerUser = (function () {
        function PokerUser() {
        }
        return PokerUser;
    })();
    Consensus.PokerUser = PokerUser;

    var PokerRoom = (function () {
        function PokerRoom() {
        }
        return PokerRoom;
    })();
    Consensus.PokerRoom = PokerRoom;

    var PokerCard = (function () {
        function PokerCard() {
        }
        return PokerCard;
    })();
    Consensus.PokerCard = PokerCard;
})(Consensus || (Consensus = {}));
