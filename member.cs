using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebid.Domain
{
    public class Member
    {
        public Member(string name)
        {
            Name = name;
            Bids = new Stack<Bid>();
        }

        public string Name { get; set; }
        public Stack<Bid> Bids { get; set; }

        public void PlaceBid(decimal bid, Item item)
        {
            if(bid > item.BidAmount)
            {
                var newBid = new Bid(this, bid, item);
                Bids.Push(newBid);
                
                item.Bids.Add(newBid);
                item.HighBidder = this;
                item.HighestBid = bid;
                item.BidAmount = bid;
            }
            
        }
    }
}
