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
        public void BidOnProduct(Bid bid)
        {
            AuctionHouseData.BidOnProduct(bid);
        }

        public List<Product> GetAllProducts()
        {
            return AuctionHouseData.GetAllProducts();
        }

        public Product GetProduct(int itemNumber)
        {
            return AuctionHouseData.GetProduct(itemNumber);
        }
    }
}
