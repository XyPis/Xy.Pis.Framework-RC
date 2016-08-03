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
    public partial class StopMealRegisterationServiceTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        int Add()
        {
            var expectedDto = new StopMealRegisterationDTO() 
            {
                OrderMealsCount = 10,
                StopMealCount = 3,                
                IsAudit = null,
                LocationID = 1517,
                OperID = 999999,
                OperTime = DateTime.Now
            };

            var response = stopMealRegisterationService.Invoke(x => x.Add(expectedDto));
            
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsNotNull(response.Result);
            Assert.AreNotEqual(0, response.Result.Id);          

            return response.Result.Id;
        }

        [TestMethod]
        public void Test_Add()
        {
            int ID = Add();

            Assert.AreNotEqual(0, ID);
        }

        [TestMethod]
        public void Test_GetAll()
        {
            int ID = Add();
            var response = stopMealRegisterationService.Invoke(x => x.GetAll());
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsTrue(response.Result.Where(x => x.Id == ID).Any());
        }

        [TestMethod]
        public void Test_GetServerDate()
        {
            var getResponse = stopMealRegisterationService.Invoke(x => x.GetDate());
        }

        [TestMethod]
        public void Test_GetById()
        {
            int ID = Add();
            var getResponse = stopMealRegisterationService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsNotNull(getResponse.Result);
        }

        [TestMethod]
        public void Test_Update()
        {
            int ID = Add();
                    
            var getResponse = stopMealRegisterationService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsNotNull(getResponse.Result);

            var dto = getResponse.Result;
            dto.AuditTime = DateTime.Now;
            dto.AuditID = 999999;
            dto.IsAudit = true;
            dto.StopMealCount = 2;
            int effectedRows = stopMealRegisterationService.Update(dto);
            Assert.AreEqual(1, effectedRows);
        }

        [TestMethod]
        public void Test_Delete()
        {
            int ID = Add();
            var getResponse = stopMealRegisterationService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);

            StopMealRegisterationDTO dto = getResponse.Result;
            Assert.IsNotNull(dto);

            var deleteResponse = stopMealRegisterationService.Invoke(x => x.Delete(dto));
            Assert.IsTrue(deleteResponse.Status == ResponseStatus.OK);
            Assert.AreEqual(1, deleteResponse.Result);
        }
    }
}