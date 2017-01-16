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
        private static object myLock = new object();

        internal static void AddProduct(Product p)
        {
            ProductList.Add(p);
        }

        internal static List<Product> GetAllProducts()
        {
            if (ProductList.Count == 0)
                Product.HardcodeProducts();

            return ProductList;
        }

        internal static Product GetProduct(int itemNumber)
        {
            if (ProductList.Count == 0)
                Product.HardcodeProducts();

            foreach (var item in ProductList)
            {
                if (item.ItemNumber == itemNumber)
                    return item;
            }

            return null;
        }

        internal static void BidOnProduct(Bid bid)
        {
            lock (myLock)
            {
                bool productExists = false;
                foreach (var item in ProductList)
                {
                    if (bid.ItemNumber == item.ItemNumber)
                    {
                        productExists = true;
                        if (bid.Price > item.BidPrice)
                        {
                            item.BidPrice = bid.Price;
                            item.BidCustomName = bid.CustomName;
                            item.BidCustomPhone = bid.CustomPhone;
                        }
                            
                        else
                            throw new Exception("Bid is too low.");
                    }
                }
                if (productExists == false)
                    throw new Exception("Product doesn't exist.");
            }
        }
    }
}