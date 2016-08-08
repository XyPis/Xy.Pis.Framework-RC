using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.Practices.Unity;
using log4net;
using System.Reflection;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Proxy;

namespace Xy.Pis.Service.UnitTests.Logistics
{
    [TestClass]
    public class DailyMenuServiceUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);       
     
        [TestMethod]
        public void Test_GetMenuByType_Return_Empty()
        {
            int type = 999999;
            var getResponse = ServiceWrapper.Invoke<IDailyMenuService, IEnumerable<FoodDTO>>(x => x.GetMenuListByType(type));            
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsTrue(!getResponse.Result.Any());
        }

        [TestMethod]
        public void Test_GetMenuByType_Return_Ok()
        {
            int type = 0;
            var getResponse = ServiceWrapper.Invoke<IDailyMenuService, IEnumerable<FoodDTO>>(x => x.GetMenuListByType(type));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsTrue(getResponse.Result.Any());            
        }

        [TestMethod]
        public void Tests_GetAll_Return_Ok()
        {
            var getResponse = ServiceWrapper.Invoke<IDailyMenuService, IEnumerable<FoodDTO>>(x => x.GetAll());
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);            
            Assert.IsTrue(getResponse.Result.Any());
        }
    }
}