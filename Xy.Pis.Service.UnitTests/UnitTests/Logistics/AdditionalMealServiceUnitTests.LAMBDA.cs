using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using log4net;
using Microsoft.Practices.Unity;
using System.Reflection;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Proxy;

namespace Xy.Pis.Service.UnitTests.Logistics
{    
    public partial class AdditionalMealServiceUnitTests : TestBase
    {
        [TestMethod]
        public void Test_RetrieveByExpression()
        {
            int ID = Add();

            var response = additionalMealService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsNotNull(response.Result);
        }   
    }
}