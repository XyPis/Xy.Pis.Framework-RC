using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using log4net;
using Microsoft.Practices.Unity;
using Xunit;
using Xy.Pis;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Proxy;

namespace Xy.Pis.Service.UnitTests.Logistics
{    
    public partial class StopMealRegisterationServiceTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);        

        [Fact]
        public void Test_StopMealRegisterationService_Add()
        {
            int id = this.Add();
        }

        [Fact]
        public void Test_StopMealRegisterationService_Delete()
        {
            int id = this.Add();
            var deleteResponse = ServiceWrapper.Invoke<IStopMealRegisterationService>(x => x.DeleteById(id));
            Assert.True(deleteResponse.Status == ResponseStatus.OK);

            var getResponse = ServiceWrapper.Invoke<IStopMealRegisterationService, StopMealRegisterationDTO>(x => x.GetById(id));
            Assert.True(getResponse.Status == ResponseStatus.OK);
            Assert.Null(getResponse.Result);
        }

        [Fact]
        public void Test_StopMealRegisterationService_Update()
        {
            int id = this.Add();
            var getResponse = ServiceWrapper.Invoke<IStopMealRegisterationService, StopMealRegisterationDTO>(x => x.GetById(id));
            Assert.True(getResponse.Status == ResponseStatus.OK);
            Assert.NotNull(getResponse.Result);

            var dto = getResponse.Result;
            dto.AuditTime = DateTime.Now;
            dto.AuditID = 999999;
            dto.IsAudit = true;
            dto.CancelQty = 2;
            var updateResponse = ServiceWrapper.Invoke<IStopMealRegisterationService>(x => x.Update(dto));
            Assert.True(updateResponse.Status == ResponseStatus.OK);            
        }

        [Fact]
        public void Test_StopMealRegisterationService_GetAll()
        {
            int id = this.Add();
            var response = ServiceWrapper.Invoke<IStopMealRegisterationService, IEnumerable<StopMealRegisterationDTO>>(x => x.GetAll());
            Assert.True(response.Status == ResponseStatus.OK);
            Assert.True(response.Result.Where(x => x.ID == id).Any());
        }

        [Fact]
        public void Test_StopMealRegisterationService_GetById()
        {
            int id = this.Add();
            var getResponse = ServiceWrapper.Invoke<IStopMealRegisterationService, StopMealRegisterationDTO>(x => x.GetById(id));
            Assert.True(getResponse.Status == ResponseStatus.OK);
            Assert.NotNull(getResponse.Result);
        }       

        [Fact]
        public void Test_StopMealRegisterationService_AddOrUpdate()
        {
            var getResponse = ServiceWrapper.Invoke<IStopMealRegisterationService, IEnumerable<StopMealRegisterationDTO>>(x => x.GetAll());

            List<StopMealRegisterationDTO> addDTOs = new List<StopMealRegisterationDTO>();
            addDTOs.Add(new StopMealRegisterationDTO()
            {
                LocationID = 1510,
                OrderQty = 100,
                CancelQty = 10,
                IsAudit = null,
                OperID = 999999,
                OperTime = DateTime.Now
            });

            addDTOs.Add(new StopMealRegisterationDTO()
            {
                LocationID = 1511,
                OrderQty = 200,
                CancelQty = 20,
                IsAudit = null,
                OperID = 999999,
                OperTime = DateTime.Now
            });

            List<StopMealRegisterationDTO> addOrUpdateDTOs = new List<StopMealRegisterationDTO>();
            var updateDTOs = getResponse.Result.Where(x => x.OperID == 999999).ToList();
            updateDTOs.ForEach(x =>
            {
                x.IsAudit = true;
                x.AuditID = 999999;
                x.AuditTime = DateTime.Now.AddDays(-10);
            });

            addOrUpdateDTOs.AddRange(addDTOs);
            addOrUpdateDTOs.AddRange(updateDTOs);

            var updateResponse = ServiceWrapper.Invoke<IStopMealRegisterationService, Tuple<int, int>>(x => x.AddOrUpdate(addOrUpdateDTOs));
            Assert.True(updateResponse.Status == ResponseStatus.OK);
            Assert.Equal(addDTOs.Count, updateResponse.Result.Item1);
            Assert.Equal(updateDTOs.Count, updateResponse.Result.Item2);
        }        
    
        [Fact]
        public void Test_StopMealRegisterationService_GetByLambdaExpressionWithKey()
        {
            int registerationId = this.Add();
            Expression<Func<StopMealRegisterationDTO, bool>> predicate = y => (y.ID == registerationId);
            var getResponse = ServiceWrapper.Invoke<IStopMealRegisterationService>(x => x.Get(predicate));
            Assert.True(getResponse.Status == ResponseStatus.OK);
        }

        [Fact]
        public void Test_StopMealRegisterationService_GetByLambdaExpression()
        {
            var getResponse = ServiceWrapper.Invoke<IStopMealRegisterationService, IEnumerable<StopMealRegisterationDTO>>(x => x.Get(y => y.AuditID.Value == 999999));
            Assert.True(getResponse.Status == ResponseStatus.OK);

            var date = DateTime.Now.AddDays(-6);
            Expression<Func<StopMealRegisterationDTO, bool>> expression = x => (x.LocationID == 1517 && x.AuditID == 999999 && x.AuditTime.Value > date);
            getResponse = ServiceWrapper.Invoke<IStopMealRegisterationService, IEnumerable<StopMealRegisterationDTO>>(x => x.Get(expression));
            Assert.True(getResponse.Status == ResponseStatus.OK);           
        }       

        [Fact]
        public void Test_StopMealRegisterationService_DeleteByLambdaWithKey()
        {
            int registerationId = this.Add();
            var getResponse = ServiceWrapper.Invoke<IStopMealRegisterationService>(x => x.Delete(y => y.ID == registerationId));
            Assert.True(getResponse.Status == ResponseStatus.OK);
        }

        [Fact]
        public void Test_StopMealRegisterationService_DeleteByLambdaExpression()
        {
            // var date = DateTime.Now.AddDays(-10);
            Expression<Func<StopMealRegisterationDTO, bool>> expression = x => (x.LocationID != 1517 && x.AuditID == 999999);

            var deleteResponse = ServiceWrapper.Invoke<IStopMealRegisterationService>(x => x.Delete(expression));
            Assert.True(deleteResponse.Status == ResponseStatus.OK);
        }

        [Fact(Skip = "Not Implemented")]
        public void Test_StopMealRegisterationService_UpdateByLambdaExpression()
        {
            Expression<Func<StopMealRegisterationDTO, bool>> predicate = x => (x.LocationID != 1517);
            
            var updateResponse = ServiceWrapper.Invoke<IStopMealRegisterationService, int>(x => x.Update(predicate, u => new StopMealRegisterationDTO() { OrderQty = 5, CancelQty = 2, IsAudit = true }));
            
            Assert.True(updateResponse.Status == ResponseStatus.OK);
        }

        private int Add()
        {
            var expectedDto = new StopMealRegisterationDTO()
            {
                LocationID = 1517,
                OrderQty = 10,
                CancelQty = 3,
                IsAudit = null,
                OperID = 999999,
                OperTime = DateTime.Now
            };

            var response = ServiceWrapper.Invoke<IStopMealRegisterationService, StopMealRegisterationDTO>(x => x.Add(expectedDto));

            Assert.True(response.Status == ResponseStatus.OK);
            Assert.NotNull(response.Result);
            Assert.NotEqual(0, response.Result.ID);

            return response.Result.ID;
        }
    }
}