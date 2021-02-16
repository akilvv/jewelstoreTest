using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyJewelStore.Repository;
using DataModel.Models.Master;
using DataModel.Models.Enum;
using MyJewelStore.Common;
using DataModel.Models.Pricing;

namespace MyJewelStore.BusinessLogic
{
    public interface IPricingService
    {

        void EstimatePrice(PriceModel priceModel, out float finalPrice);
        string EstimatePrice(PriceModel priceModel, PrintType pType);


    }
}