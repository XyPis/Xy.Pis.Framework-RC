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
    [TestClass]
    public partial class AdditionalMealServiceUnitTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);        

        [TestMethod]
        public void Test_AdditionalMealService_Add()
        {
            this.Add();
        }

        [TestMethod]
        public void Test_AdditionalMealService_GetAll()
        {
            int id = this.Add();
            var response = ServiceWrapper.Invoke<IAdditionalMealService, IEnumerable<AdditionalMealDTO>>(x => x.GetAll());
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsTrue(response.Result.Where(x => x.ID == id).Any());
        }

        [TestMethod]
        public void Test_AdditionalMealService_GetById()
        {
            int id = this.Add();
            var response = ServiceWrapper.Invoke<IAdditionalMealService, AdditionalMealDTO>(x => x.GetById(id));
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsNotNull(response.Result);
        }

        [TestMethod]
        public void Test_AdditionalMealService_Update()
        {
            string additionalMealType = "L";

            int id = this.Add();
            var retrieveResponse = ServiceWrapper.Invoke<IAdditionalMealService, AdditionalMealDTO>(x => x.GetById(id));            
            Assert.IsTrue(retrieveResponse.Status == ResponseStatus.OK);

            AdditionalMealDTO additionalMealDto = retrieveResponse.Result;
            Assert.IsNotNull(additionalMealDto);
            additionalMealDto.OrderStatus = 2;
            additionalMealDto.Details.FirstOrDefault().AdditionalMealType = additionalMealType;
            additionalMealDto.Details.FirstOrDefault().Food = null;
            additionalMealDto.Details.FirstOrDefault().FoodId = 15;
            var updateResponse = ServiceWrapper.Invoke<IAdditionalMealService>(x => x.Update(additionalMealDto));

            Assert.IsTrue(updateResponse.Status == ResponseStatus.OK);

            retrieveResponse = ServiceWrapper.Invoke<IAdditionalMealService, AdditionalMealDTO>(x => x.GetById(id));
            Assert.IsTrue(retrieveResponse.Status == ResponseStatus.OK);
            Assert.IsTrue(retrieveResponse.Result.Details.FirstOrDefault().AdditionalMealType == additionalMealType);
        }

        [TestMethod]
        public void Test_AdditionalMealService_Delete()
        {
            int id = this.Add();
            var retrieveResponse = ServiceWrapper.Invoke<IAdditionalMealService, AdditionalMealDTO>(x => x.GetById(id));
            Assert.IsTrue(retrieveResponse.Status == ResponseStatus.OK);

            AdditionalMealDTO additionalMealDto = retrieveResponse.Result;
            Assert.IsNotNull(additionalMealDto);

            var deleteResponse = ServiceWrapper.Invoke<IAdditionalMealService>(x => x.Delete(additionalMealDto));
            Assert.IsTrue(deleteResponse.Status == ResponseStatus.OK);            
        }

        [TestMethod]
        public void Test_AdditionalMealService_GetLastAdditionalMealByHospId()
        {
            int id = this.Add();
            int hospId = 18;

            var response = ServiceWrapper.Invoke<IAdditionalMealService, AdditionalMealDTO>(x => x.GetLastAdditionalMealByHospId(hospId));
            Assert.IsTrue(response.Status == ResponseStatus.OK);                     
        }

        private int Add()
        {
            decimal unitPrice = 21;
            int hospId = 18;
            int locationId = 1517;
            DateTime orderDate = DateTime.Now.AddDays(-3);

            var expectedDto = PrepareData(hospId, locationId, orderDate, unitPrice);

            var response = ServiceWrapper.Invoke<IAdditionalMealService, AdditionalMealDTO>(x => x.Add(expectedDto));

            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsNotNull(response.Result);
            Assert.AreNotEqual(0, response.Result.ID);
            Assert.AreEqual(expectedDto.Details.Count, response.Result.Details.Count);

            return response.Result.ID;
        }
    }
}