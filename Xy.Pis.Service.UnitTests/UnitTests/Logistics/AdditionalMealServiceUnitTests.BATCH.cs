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
        public void Test_AdditionalMealService_AddBatch()
        {
            IList<AdditionalMealDTO> dtoList = new List<AdditionalMealDTO>();             
            decimal unitPrice = 21;
            int hospId = 18;
            int locationId = 1517;
            DateTime orderDate = DateTime.Now.AddDays(-5);

            var expectedDto = this.PrepareData(hospId, locationId, orderDate, unitPrice);
            for (int i = 0; i < 20; i++)
            {
                dtoList.Add(this.PrepareData(hospId, locationId, orderDate, 20));
            }

            var response = ServiceWrapper.Invoke<IAdditionalMealService, int>(x => x.AddBatch(dtoList));
            Assert.IsTrue(response.Status == ResponseStatus.OK);
        }

        [TestMethod]
        public void Test_AdditionalMealService_UpdateBatch()
        {
            int[] ids = new int[] { this.Add(), this.Add(), this.Add() };
            var getResponse = ServiceWrapper.Invoke<IAdditionalMealService, IEnumerable<AdditionalMealDTO>>(x => x.GetAll().Where(y => ids.Contains(y.ID)));
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

            var updateResponse = ServiceWrapper.Invoke<IAdditionalMealService, int>(x => x.UpdateBatch(getResponse.Result));
            Assert.IsTrue(updateResponse.Status == ResponseStatus.OK);

            // Assert.AreEqual(getResponse.Result.Count, updateResponse.Result);
        }

        [TestMethod]
        public void Test_AdditionalMealService_DeleteBatch()
        {
            this.Add();
            var getResponse = ServiceWrapper.Invoke<IAdditionalMealService, IEnumerable<AdditionalMealDTO>>(x => x.GetAll());
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsNotNull(getResponse.Result);
            var deleteResponse = ServiceWrapper.Invoke<IAdditionalMealService, int>(x => x.DeleteBatch(getResponse.Result));
            Assert.IsTrue(deleteResponse.Status == ResponseStatus.OK);
        }
    }
}