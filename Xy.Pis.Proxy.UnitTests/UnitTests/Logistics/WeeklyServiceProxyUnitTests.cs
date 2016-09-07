using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using Xunit;
using Xy.Pis.Contract.Service.Logistics;

namespace Xy.Pis.Proxy.UnitTests.Logistics
{    
    public partial class WeeklyServiceProxyUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
               
        public void Test_WeeklyMenuService_GetLastSunday() 
        {            
            ClientProxy proxy = new ClientProxy();
            var weeklyMenuService = proxy.GetContract<IWeeklyMenuService>();
            var lastSunDay = weeklyMenuService.GetLastSunday();
            Assert.NotEqual(DateTime.MinValue, lastSunDay);
        }

        [Fact(Skip="重构未完成")]
        public void Test_WeeklyMenuService_GetWeeklyMenu()
        {
            ClientProxy proxy = new ClientProxy();
            var weeklyMenuService = proxy.GetContract<IWeeklyMenuService>();
            var weeklyMenu = weeklyMenuService.GetWeeklyMenu();
            Assert.True(weeklyMenu.Any());
        }
    }
}