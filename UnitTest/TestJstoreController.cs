using System;
using DataModel.Models.Enum;
using DataModel.Models.Master;
using DataModel.Models.Pricing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyJewelStore.BusinessLogic;
using MyJewelStore.Common;
using MyJewelStore.Controllers;
using MyJewelStore.Repository;

namespace UnitTest
{
  

    [TestClass]
    public class TestJstoreController
    {
        IDataRepository dataRepo = new Mock<DataRepository>().Object;
        IHelper help = new Mock<Helper>().Object;
        IPrintEstimationService printEstimate = new Mock<PrintEstimationService>().Object;

        [TestMethod]
        public void AuthorizeNormalUser()
        {
            string userName = "Test1.User1";
            string password = "TestTest";
            string expectedOutput = "{\"Status\":\"True\",\"UserType\":\"normalUser\"}";

            IAuthService mockAuthService = new Mock<AuthService>(dataRepo, help).Object;
            IPricingService mockPricingService = new Mock<PricingService>(printEstimate).Object;

            var JstoreController = new JstoreController(mockAuthService, mockPricingService);
            string result = JstoreController.AuthenticateUser(userName, password);

            Assert.AreEqual(expectedOutput, result);        
        }


        [TestMethod]
        public void AuthorizePrivilagedUser()
        {
            string userName = "Test2.User2";
            string password = "TestTest";
            string expectedOutput = "{\"Status\":\"True\",\"UserType\":\"privilaged\"}";

            IAuthService mockAuthService = new Mock<AuthService>(dataRepo, help).Object;
            IPricingService mockPricingService = new Mock<PricingService>(printEstimate).Object;

            var JstoreController = new JstoreController(mockAuthService, mockPricingService);
            string result = JstoreController.AuthenticateUser(userName, password);
            Assert.AreEqual(expectedOutput, result);
        }


        [TestMethod]
        public void EstimatePriceDiscount()
        {
            PriceModel model = new PriceModel();
            model.price = 4987;
            model.weight = 30;
            model.discount = 100;
            float expectedOutput = 149510;    

            IAuthService mockAuthService = new Mock<AuthService>(dataRepo, help).Object;
            IPricingService mockPricingService = new Mock<PricingService>(printEstimate).Object;

            var JstoreController = new JstoreController(mockAuthService, mockPricingService);
            float result = JstoreController.EstimatePrice(model);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void EstimatePriceNoDiscount()
        {
            PriceModel model = new PriceModel();
            model.price = 4387;
            model.weight = 26;
            model.discount = 0;
            float expectedOutput = 114062;

            IAuthService mockAuthService = new Mock<AuthService>(dataRepo, help).Object;
            IPricingService mockPricingService = new Mock<PricingService>(printEstimate).Object;

            var JstoreController = new JstoreController(mockAuthService, mockPricingService);
            float result = JstoreController.EstimatePrice(model);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void PrintPriceScreen()
        {
            PriceModel model = new PriceModel();
            model.price = 4387;
            model.weight = 26;
            model.discount = 0;
            model.finalPrice = 114062;
            string expectedOutput = "Gold Price: 4387 Rs\r\nWeight: 26 gms\r\nFinal Price: 114062 Rs";

            IAuthService mockAuthService = new Mock<AuthService>(dataRepo, help).Object;
            IPricingService mockPricingService = new Mock<PricingService>(printEstimate).Object;

            var JstoreController = new JstoreController(mockAuthService, mockPricingService);
            string result = JstoreController.PrintpriceEstimation(model,PrintType.printOnScreen);
            Assert.AreEqual(expectedOutput, result);
        }


        [TestMethod]
        public void PrintPricePaper()
        {
            PriceModel model = new PriceModel();
            model.price = 4387;
            model.weight = 26;
            model.discount = 0;
            model.finalPrice = 114062;
            string expectedOutput = "The method or operation is not implemented.";

            IAuthService mockAuthService = new Mock<AuthService>(dataRepo, help).Object;
            IPricingService mockPricingService = new Mock<PricingService>(printEstimate).Object;

            var JstoreController = new JstoreController(mockAuthService, mockPricingService);
            var ex = JstoreController.PrintpriceEstimation(model, PrintType.printToPaper);
            Assert.AreEqual(ex, expectedOutput);
        }


    }
}
