using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfWebApplication
{
    public class Bid
    {
        public int ItemNumber { get; set; }
        public decimal Price { get; set; }
        public string CustomName { get; set; }
        public int CustomPhone { get; set; }
    }
}