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
    public class WeeklyMenuServiceUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
     
        [TestMethod]
        public void Test_WeeklyMenuService_GetLastSunday()
        {
            var response = ServiceWrapper.Invoke<IWeeklyMenuService, DateTime>(x => x.GetLastSunday());
            Assert.AreEqual(ResponseStatus.OK, response.Status);
            Assert.AreNotEqual(DateTime.MinValue, response.Result);
        }

        [TestMethod]
        public void Test_WeeklyMenuService_GetWeeklyMenu() 
        {
            var response = ServiceWrapper.Invoke<IWeeklyMenuService, IEnumerable<WeeklyMenuDTO>>(x => x.GetWeeklyMenu());
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsTrue(response.Result.Any());
        }

        [TestMethod]
        public void Test_WeeklyMenuService_Retrieve()
        {
            int weeklyMenuId = 15;
            var response = ServiceWrapper.Invoke<IWeeklyMenuService, IEnumerable<WeeklyMenuDTO>>(y => 
                y.GetAll().Where(x => x.ID == weeklyMenuId).ToList());

            Assert.AreEqual(ResponseStatus.OK, response.Status);
            Assert.IsNotNull(response.Result);
            Assert.IsTrue(response.Result.Count() > 0);
            if (response.Result != null)
            {
                Assert.AreEqual(weeklyMenuId, response.Result.First().ID);
            }
        }
    }
}