using log4net;
using MyJewelStore.Repository;
using MyJewelStore.Common;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.IO;
using MyJewelStore.BusinessLogic;
using MyJewelStore.Models;
using DataModel.Models.Pricing;
using DataModel.Models.Enum;
//using DocumentFormat.OpenXml.Spreadsheet;

namespace MyJewelStore.Controllers
{
    public class JstoreController : Controller
    {
        private IAuthService _authService;
        private IPricingService _pricingService;
        public JstoreController(IAuthService authService, IPricingService pricingService)
        {
            this._authService = authService;
            this._pricingService = pricingService;
        }

        [HttpGet]
        public string AuthenticateUser(string userName, string password)
        {
            Dictionary<string, string> retDict = new Dictionary<string, string>();
            string retString = string.Empty;
            try
            {
                retDict = _authService.AuthorizeUser(userName, password);
                var jsonSettings = new JsonSerializerSettings();
                retString = Newtonsoft.Json.JsonConvert.SerializeObject(retDict, jsonSettings);
            }
            catch (Exception ex)
            {
                throw ex;
                //Log Exception
            }
            return retString;
        }


        [HttpGet]
        public float EstimatePrice(PriceModel priceModel)
        {
            float finalPrice = float.MinValue;
            try
            {
                _pricingService.EstimatePrice(priceModel, out finalPrice);
            }
            catch (Exception ex)
            {
                throw ex;
                //Log Exception
            }
            return finalPrice;
        }

        [HttpGet]
        public string PrintpriceEstimation(PriceModel priceModel, PrintType pType)
        {
            string retString = string.Empty;
            try
            {
                retString = _pricingService.EstimatePrice(priceModel, pType);
            }
            catch (Exception ex)
            {
                retString = ex.Message;
                //Log Exception
            }
            return retString;
        }

    }


}
