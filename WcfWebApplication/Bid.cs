using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfWebApplication
{
    [DataContract]
    public class Bid
    {
        [DataMember]
        public int ItemNumber { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string CustomName { get; set; }
        [DataMember]
        public int CustomPhone { get; set; }

        public Bid(int itemNumber, decimal price, string customName, int customPhone)
        {
            ItemNumber = itemNumber;
            Price = price;
            CustomName = customName;
            CustomPhone = customPhone;
        }
    }
}