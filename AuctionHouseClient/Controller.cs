using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionHouseClient.AuctionHouseServiceReference;

namespace AuctionHouseClient
{
    class Controller
    {
        AuctionHouseServiceClient client;

        public Controller()
        {
            client = new AuctionHouseServiceClient();
        }

        public void BidOnProduct(string text1, string text2, string text3, string text4)
        {
            int itemNumber = int.Parse(text1);
            decimal price = decimal.Parse(text2);
            string customName = text3;
            int customPhone = int.Parse(text4);
            Bid bid = new Bid();
            bid.ItemNumber = itemNumber;
            bid.Price = price;
            bid.CustomName = customName;
            bid.CustomPhone = customPhone;
            client.BidOnProduct(bid);
        }

        public List<Product> GetAllProducts()
        {
            return client.GetAllProducts();
        }

        public Product GetProduct(string text1)
        {
            int itemNumber = int.Parse(text1);
            return client.GetProduct(itemNumber);
        }
    }
}
