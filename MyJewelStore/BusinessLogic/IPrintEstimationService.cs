using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using DataModel.Models.Pricing;

namespace MyJewelStore.BusinessLogic
{
    public interface IPrintEstimationService
    {
        //print on Screen is handled by FrontEnd
        //We are building the string just for representational purpose
        void PrintOnScreen(PriceModel priceModel, out string result);

        void PrintToPaper(PriceModel priceModel, out string result);
    }
}