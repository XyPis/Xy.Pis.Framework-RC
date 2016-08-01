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
        #region Batch Method
        [TestMethod]
        public void Test_AddBatch()
        {
            IList<AdditionalMealDTO> dtoList = new List<AdditionalMealDTO>();             
            decimal unitPrice = 21;
            int hospId = 18;
            int locationId = 1517;
            DateTime orderDate = DateTime.Now.AddDays(-5);

            var expectedDto = PrepareData(hospId, locationId, orderDate, unitPrice);
            for (int i = 0; i < 20; i++)
            {
                dtoList.Add(PrepareData(hospId, locationId, orderDate, 20));
            }

            var response = additionalMealService.Invoke(x => x.AddBatch(dtoList));
            Assert.IsTrue(response.Status == ResponseStatus.OK);
        }

        [TestMethod]
        public void Test_UpdateBatch()
        {
            int[] ids = new int[] { Add(), Add(), Add() };
            var getResponse = additionalMealService.Invoke(x => x.Get(y => ids.Contains(y.Id)));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);

            foreach (var dto in getResponse.Result)
            {
                dto.OrderDate = DateTime.Now.AddDays(10);
                dto.OrderStatus = 3;
                int i = 10;
                foreach (var dtl in dto.Details)
                {
                    dtl.UnitPrice += i + 100;
                    i++;
                }
            }

            var updateResponse = additionalMealService.Invoke(x => x.UpdateBatch(getResponse.Result));
            Assert.IsTrue(updateResponse.Status == ResponseStatus.OK);
            //Assert.AreEqual(getResponse.Result.Count, updateResponse.Result);
        }

        [TestMethod]
        public void Test_DeleteBatch()
        {
            Add();
            var getResponse = additionalMealService.Invoke(x => x.GetAll());
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsNotNull(getResponse.Result);
            var deleteResponse = additionalMealService.Invoke(x => x.DeleteBatch(getResponse.Result));
            Assert.IsTrue(deleteResponse.Status == ResponseStatus.OK);
        }
        #endregion Batch Method
    }
}