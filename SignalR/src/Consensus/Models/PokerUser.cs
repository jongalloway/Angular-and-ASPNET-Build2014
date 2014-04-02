using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consensus.Models
{
	public class PokerUser
	{
		public string Name { get; set; }
		public string Email { get; set; }

		public DateTimeOffset? Disconnected { get; set; }
	}
}