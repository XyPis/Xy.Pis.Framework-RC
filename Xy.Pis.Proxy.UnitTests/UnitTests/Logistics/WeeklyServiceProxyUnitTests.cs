using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xy.Pis.Contract.Service.Logistics;

namespace Xy.Pis.Proxy.UnitTests.Logistics
{
    [TestClass]
    public partial class WeeklyServiceProxyUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
       
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