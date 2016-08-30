using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using log4net;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Proxy;

namespace Xy.Pis.Service.UnitTests.Logistics
{
    [TestClass]
    public class DailyMenuServiceUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);       
     
        [TestMethod]
        public void Test_DailyMenuService_GetMenuByType_ReturnEmpty()
        {
            int type = 999999;
            var getResponse = ServiceWrapper.Invoke<IDailyMenuService, IEnumerable<FoodDTO>>(x => x.GetMenuListByType(type));            
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsTrue(!getResponse.Result.Any());
        }

        [TestMethod]
        public void Test_DailyMenuService_GetMenuByType_ReturnOk()
        {
            int type = 0;
            var getResponse = ServiceWrapper.Invoke<IDailyMenuService, IEnumerable<FoodDTO>>(x => x.GetMenuListByType(type));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsTrue(getResponse.Result.Any());            
        }

        [TestMethod]
        public void Test_DailyMenuService_GetAll()
        {
            var getResponse = ServiceWrapper.Invoke<IDailyMenuService, IEnumerable<FoodDTO>>(x => x.GetAll());
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);            
            Assert.IsTrue(getResponse.Result.Any());
        }
    }
}