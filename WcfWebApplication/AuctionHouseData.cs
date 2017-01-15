using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfWebApplication
{
    [DataContract]
    public class AuctionHouseData
    {
        [DataMember]
        private static List<Product> ProductList = new List<Product>();

        internal static void AddProduct(Product p)
        {
            ProductList.Add(p);
        }

        internal static List<Product> GetAllProducts()
        {
            return ProductList;
        }
    }
}