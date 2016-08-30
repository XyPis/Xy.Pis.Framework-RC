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
    public partial class AdditionalMealServiceUnitTests : TestBase
    {
        [TestMethod]
        public void Test_AdditionalMealService_GetByExpression()
        {
            int additionalMealId = this.Add();

            var response = ServiceWrapper.Invoke<IAdditionalMealService, IEnumerable<AdditionalMealDTO>>(x => x.Get(y => y.ID == additionalMealId));
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsNotNull(response.Result);
        }   
    }
}