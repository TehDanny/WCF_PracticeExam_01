using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfWebApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuctionHouseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuctionHouseService.svc or AuctionHouseService.svc.cs at the Solution Explorer and start debugging.
    public class AuctionHouseService : IAuctionHouseService
    {
        List<Product> ProductList = new List<Product>();
        private object myLock = new object();

        public void BidOnProduct(Bid bid)
        {
            lock(myLock)
            {
                foreach (var item in ProductList)
                {
                    if (bid.ItemNumber == item.ItemNumber)
                        if (bid.Price > item.BidPrice)
                            item.BidPrice = bid.Price;
                        else
                            throw new Exception("Bid is too low.");
                    else
                        throw new Exception("Product doesn't exist.");
                }
            }
        }

        public List<Product> GetAllProducts()
        {
            return AuctionHouseData.GetAllProducts();
        }

        public Product GetProduct(int ItemNumber)
        {
            foreach (var item in ProductList)
            {
                if (item.ItemNumber == ItemNumber)
                    return item;
            }

            return null;
        }

        
    }
}
