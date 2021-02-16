using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using DataModel.Models.Pricing;

namespace MyJewelStore.BusinessLogic
{
    public class PrintEstimationService: IPrintEstimationService
    {
        //print on Screen is handled by FrontEnd
        //We are building the string just for representational purpose
        public void PrintOnScreen(PriceModel priceModel, out string result)
        {
                StringBuilder sb = new StringBuilder();
                sb.Append("Gold Price: " + priceModel.price + " Rs" + "\r\n");
                sb.Append("Weight: " + priceModel.weight + " gms" + "\r\n");
                if (priceModel.discount != 0)
                    sb.Append("Discount: " + priceModel.discount + " Rs" + "\r\n");
                sb.Append("Final Price: " + priceModel.finalPrice + " Rs");
                result = sb.ToString();      
        }

        public void PrintToPaper(PriceModel priceModel, out string result)
        {
            throw new NotImplementedException();
        }
    }
}