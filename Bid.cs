using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebid.Domain
{
    public class Bid
    {
        public Member Bidder { get; set; }
        public decimal Amount { get; set; }
        public Item Item { get; set; }

        public Bid(Member bidder, decimal amount, Item item)
        {
            Bidder = bidder;
            Amount = amount;
            Item = item;
        }
    }
}
