using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Consensus.Models
{
	public class PokerRoom
	{
		public PokerRoom()
		{
			Users = new List<PokerUser>();
			Cards = new List<PokerCard>();
		}

		public string Name { get; set; }
		public string Topic { get; set; }

		public virtual ICollection<PokerUser> Users { get; set; } 
		public virtual ICollection<PokerCard> Cards { get; set; } 
	}
}