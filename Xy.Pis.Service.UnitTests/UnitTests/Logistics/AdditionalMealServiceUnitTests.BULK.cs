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
        public void Test_BulkInsert()
        {
            IList<AdditionalMealDTO> dtoList = new List<AdditionalMealDTO>();
            decimal unitPrice = 15;
            int hospId = 18;
            int locationId = 1517;
            DateTime orderDate = DateTime.Now.AddDays(-3);

            for (int i = 0; i < 10000; i++)
            {
                dtoList.Add(PrepareData(hospId, locationId, orderDate, unitPrice));
            }

            var response = ServiceWrapper.Invoke<IAdditionalMealService>(x => x.BulkInsert(dtoList));
            Assert.IsTrue(response.Status == ResponseStatus.OK);
        }

        [TestMethod]
        public void Test_BulkUpdate()
        {
            var getResponse = ServiceWrapper.Invoke<IAdditionalMealService>.Invoke(x => x.GetAll());
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            int orderLineNo = 0;

            getResponse.Result.ToList().ForEach(x => 
            {
                orderLineNo++;                
                x.OrderStatus = 3;
                x.OrderDate = DateTime.Now.AddDays(10);

                int detailItemNo = 0;
                x.Details.ToList().ForEach(dtl => 
                {
                    detailItemNo++;
                    dtl.UnitPrice = orderLineNo + detailItemNo;
                });                
            });

            var updateResponse = additionalMealService.Invoke(x => x.BulkUpdate(getResponse.Result));
            Assert.IsTrue(updateResponse.Status == ResponseStatus.OK);
        }

        [TestMethod]
        public void Test_BulkDelete()
        {
            var getResponse = additionalMealService.Invoke(x => x.GetAll());
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsNotNull(getResponse.Result);
            var deleteResponse = additionalMealService.Invoke(x => x.BulkDelete(getResponse.Result));
            Assert.IsTrue(deleteResponse.Status == ResponseStatus.OK);
        }
    }
}