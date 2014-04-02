using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consensus.Models
{
	public class PokerCard
	{
		public PokerUser User { get; set; }
		public string Value { get; set; }
	}
}