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
    [TestClass]
    public partial class AdditionalMealServiceUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        int Add()
        {
            decimal unitPrice = 21;
            int hospId = 18;            
            int locationId = 1517;
            DateTime orderDate = DateTime.Now.AddDays(-3);

            var expectedDto = PrepareData(hospId, locationId, orderDate, unitPrice);

            var response = additionalMealService.Invoke(x => x.Add(expectedDto));
            
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsNotNull(response.Result);
            Assert.AreNotEqual(0, response.Result.Id);
            Assert.AreEqual(expectedDto.Details.Count, response.Result.Details.Count);            

            return response.Result.Id;
        }

        [TestMethod]
        public void Test_Add()
        {
            Add();
        }

        [TestMethod]
        public void Test_GetAll()
        {
            int ID = Add();
            var response = additionalMealService.Invoke(x => x.GetAll());
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsTrue(response.Result.Where(x => x.Id == ID).Any());
        }

        [TestMethod]
        public void Test_GetById()
        {
            int ID = Add();
            var response = additionalMealService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsNotNull(response.Result);
        }

        [TestMethod]
        public void Test_Update()
        {
            string additionalMealType = "L";

            int ID = Add();
            var retrieveResponse = additionalMealService.Invoke(x => x.GetById(ID));            
            Assert.IsTrue(retrieveResponse.Status == ResponseStatus.OK);

            AdditionalMealDTO additionalMealDto = retrieveResponse.Result;
            Assert.IsNotNull(additionalMealDto);
            additionalMealDto.OrderStatus = 2;
            additionalMealDto.Details.FirstOrDefault().AdditionalMealType = additionalMealType;
            additionalMealDto.Details.FirstOrDefault().Food = null;
            additionalMealDto.Details.FirstOrDefault().FoodId = 15;
            var updateResponse = additionalMealService.Invoke(x => x.Update(additionalMealDto));

            Assert.IsTrue(updateResponse.Status == ResponseStatus.OK);

            retrieveResponse = additionalMealService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(retrieveResponse.Status == ResponseStatus.OK);
            Assert.IsTrue(retrieveResponse.Result.Details.FirstOrDefault().AdditionalMealType == additionalMealType);
        }

        [TestMethod]
        public void Test_Delete()
        {
            int ID = Add();
            var retrieveResponse = additionalMealService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(retrieveResponse.Status == ResponseStatus.OK);

            AdditionalMealDTO additionalMealDto = retrieveResponse.Result;
            Assert.IsNotNull(additionalMealDto);

            var deleteResponse = additionalMealService.Invoke(x => x.Delete(additionalMealDto));
            Assert.IsTrue(deleteResponse.Status == ResponseStatus.OK);
            Assert.AreEqual(1, deleteResponse.Result);
        }

        [TestMethod]
        public void Test_GetLastAdditionalMealByHospId()
        {
            int ID = Add();
            int hospId = 18;

            var response = additionalMealService.Invoke(x => x.GetLastAdditionalMealByHospId(hospId));
            Assert.IsTrue(response.Status == ResponseStatus.OK);                     
        }
    }
}