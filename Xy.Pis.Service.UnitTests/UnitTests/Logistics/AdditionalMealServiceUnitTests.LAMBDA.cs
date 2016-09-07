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
    public partial class AdditionalMealServiceUnitTests : TestBase
    {
        [Fact]
        public void Test_AdditionalMealService_GetByExpression()
        {
            int additionalMealId = this.Add();

            var response = ServiceWrapper.Invoke<IAdditionalMealService, IEnumerable<AdditionalMealDTO>>(x => x.Get(y => y.ID == additionalMealId));
            Assert.True(response.Status == ResponseStatus.OK);
            Assert.NotNull(response.Result);
        }   
    }
}