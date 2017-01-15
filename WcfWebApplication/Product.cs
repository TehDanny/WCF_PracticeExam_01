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

        public Product(int itemNumber, string itemDescription, decimal ratingPrice, decimal bidPrice, string bidCustomName, int bidCustomPhone, DateTime bidTimestamp)
        {
            ItemNumber = itemNumber;
            ItemDescription = itemDescription;
            RatingPrice = ratingPrice;
            BidPrice = bidPrice;
            BidCustomName = bidCustomName;
            BidCustomPhone = bidCustomPhone;
            BidTimestamp = bidTimestamp;
        }

        void HardcodeProducts()
        {
            Product p1 = new Product(1, "Brugt cykel", 1000.00M, 500.00M, "Daniel Alexander Nedergaard", 12345678, DateTime.Now);
            Product p2 = new Product(1, "Smart ny bil", 50000.00M, 75000.00M, "Daniel Alexander Nedergaard", 12345678, DateTime.Now);
            AuctionHouseData.AddProduct(p1);
            AuctionHouseData.AddProduct(p2);
        }
    }
}