using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using log4net;
using Xy.Pis.Contract.Service.Logistics;

namespace Xy.Pis.Proxy.UnitTests.Logistics
{
    [TestClass]
    public partial class WeeklyServiceProxyUnitTests : TestBase
    {
        private ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
       
        [TestMethod]
        public void Test_WeeklyMenuService_GetLastSunday() 
        {            
            ClientProxy proxy = new ClientProxy();
            var weeklyMenuService = proxy.GetContract<IWeeklyMenuService>();
            var lastSunDay = weeklyMenuService.GetLastSunday();
            Assert.AreNotEqual(DateTime.MinValue, lastSunDay);
        }

        [TestMethod]
        public void Test_WeeklyMenuService_GetWeeklyMenu()
        {
            ClientProxy proxy = new ClientProxy();
            var weeklyMenuService = proxy.GetContract<IWeeklyMenuService>();
            var weeklyMenu = weeklyMenuService.GetWeeklyMenu();
            Assert.IsTrue(weeklyMenu.Any());
        }
    }
}