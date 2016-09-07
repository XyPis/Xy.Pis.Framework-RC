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
    public class DailyMenuServiceUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);       
     
        [Fact]
        public void Test_DailyMenuService_GetMenuByType_ReturnEmpty()
        {
            int type = 999999;
            var getResponse = ServiceWrapper.Invoke<IDailyMenuService, IEnumerable<FoodDTO>>(x => x.GetMenuListByType(type));            
            Assert.True(getResponse.Status == ResponseStatus.OK);
            Assert.True(!getResponse.Result.Any());
        }

        [Fact]
        public void Test_DailyMenuService_GetMenuByType_ReturnOk()
        {
            int type = 0;
            var getResponse = ServiceWrapper.Invoke<IDailyMenuService, IEnumerable<FoodDTO>>(x => x.GetMenuListByType(type));
            Assert.True(getResponse.Status == ResponseStatus.OK);
            Assert.True(getResponse.Result.Any());            
        }

        [Fact]
        public void Test_DailyMenuService_GetAll()
        {
            var getResponse = ServiceWrapper.Invoke<IDailyMenuService, IEnumerable<FoodDTO>>(x => x.GetAll());
            Assert.True(getResponse.Status == ResponseStatus.OK);            
            Assert.True(getResponse.Result.Any());
        }
    }
}