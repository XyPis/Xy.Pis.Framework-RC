using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using log4net;
using Microsoft.Practices.Unity;
using Xunit;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Proxy;

namespace Xy.Pis.Service.UnitTests.Logistics
{    
    public class WeeklyMenuServiceUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
         
        [Fact(Skip = "重构未完成")]
        public void Test_WeeklyMenuService_GetLastSunday()
        {
            var response = ServiceWrapper.Invoke<IWeeklyMenuService, DateTime>(x => x.GetLastSunday());
            Assert.Equal(ResponseStatus.OK, response.Status);
            Assert.NotEqual(DateTime.MinValue, response.Result);
        }
         
        [Fact(Skip = "重构未完成")]
        public void Test_WeeklyMenuService_GetWeeklyMenu() 
        {
            var response = ServiceWrapper.Invoke<IWeeklyMenuService, IEnumerable<WeeklyMenuDTO>>(x => x.GetWeeklyMenu());
            Assert.True(response.Status == ResponseStatus.OK);
            Assert.True(response.Result.Any());
        }

        [Fact(Skip="重构未完成")]
        public void Test_WeeklyMenuService_Retrieve()
        {
            int weeklyMenuId = 15;
            var response = ServiceWrapper.Invoke<IWeeklyMenuService, IEnumerable<WeeklyMenuDTO>>(y => 
                y.GetAll().Where(x => x.ID == weeklyMenuId).ToList());

            Assert.Equal(ResponseStatus.OK, response.Status);
            Assert.NotNull(response.Result);
            Assert.True(response.Result.Count() > 0);
            if (response.Result != null)
            {
                Assert.Equal(weeklyMenuId, response.Result.First().ID);
            }
        }
    }
}