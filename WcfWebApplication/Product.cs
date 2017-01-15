using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfWebApplication
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ItemNumber { get; set; }
        [DataMember]
        public string ItemDescription { get; set; }
        [DataMember]
        public decimal RatingPrice { get; set; }
        [DataMember]
        public decimal BidPrice { get; set; }
        [DataMember]
        public string BidCustomName { get; set; }
        [DataMember]
        public int BidCustomPhone { get; set; }
        [DataMember]
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