using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using log4net;
using Microsoft.Practices.Unity;
using System.Reflection;
using Xy.Pis.ServiceContract.Logistics;

namespace Xy.Pis.Service.UnitTests.Logistics
{    
    [TestClass]
    public class WeeklyMenuServiceUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //private static readonly IWeeklyMenuService weeklyMenuService = Client.ServiceManager.GetService<IWeeklyMenuService>();

        [TestMethod]
        public void Test_GetLastSunday()
        {
            var response = weeklyMenuService.Invoke(x => x.GetLastSunday());
            Assert.AreEqual(ResponseStatus.OK, response.Status);
            Assert.AreNotEqual(DateTime.MinValue, response.Result);
        }

        [TestMethod]
        public void Test_GetWeeklyMenu() 
        {
            var response = weeklyMenuService.Invoke(x => x.GetWeeklyMenu());
            Assert.AreEqual(ResponseStatus.OK, response.Status);
            Assert.IsTrue(response.Result.Any());
        }

        [TestMethod]
        public void Test_Retrieve()
        {
            int weeklyMenuId = 15;
            var response = weeklyMenuService.Invoke(y => y.GetAll().Where(x => x.Id == weeklyMenuId).ToList());
            Assert.AreEqual(ResponseStatus.OK, response.Status);
            Assert.IsNotNull(response.Result);
            Assert.IsTrue(response.Result.Count > 0);
            if (response.Result != null)
            {
                Assert.AreEqual(weeklyMenuId, response.Result.First().Id);
            }
        }
    }
}