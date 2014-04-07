using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebid.Domain
{
    public class Item
    {
        public string Name { get; set; }
        public Member HighBidder { get; set; }
        public decimal HighestBid { get; set; }
        public List<Bid> Bids { get; set; }
        public decimal BidAmount { get; set; }

        public Item(string name)
        {
            Name = name;
            Bids = new List<Bid>();
            BidAmount = 0m;
        }
    }
}
