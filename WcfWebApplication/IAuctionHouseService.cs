﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfWebApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuctionHouseService" in both code and config file together.
    [ServiceContract]
    public interface IAuctionHouseService
    {
        [OperationContract]
        List<Product> GetAllProducts();
        [OperationContract]
        Product GetProduct(int itemNumber);
        [OperationContract]
        void BidOnProduct(Bid bid);
    }
}
