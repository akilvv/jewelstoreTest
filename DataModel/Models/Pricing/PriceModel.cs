using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataModel.Models.Pricing
{
    public class PriceModel
    {
        public float price { get; set; }
        public float weight { get; set; }
        public float discount { get; set; }
        public float finalPrice { get; set;}
    }
}