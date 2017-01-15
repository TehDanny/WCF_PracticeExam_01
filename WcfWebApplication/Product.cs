using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfWebApplication
{
    public class Product
    {
        public int ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public decimal RatingPrice { get; set; }
        public decimal BidPrice { get; set; }
        public string BidCustomName { get; set; }
        public int BidCustomPhone { get; set; }
        public DateTime BidTimestamp { get; set; }
    }
}