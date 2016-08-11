using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using log4net;
using Microsoft.Practices.Unity;
using System.Reflection;
using System.Linq.Expressions;
using Xy.Pis.Contract.Message.Logistics;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Proxy;

namespace Xy.Pis.Service.UnitTests.Logistics
{
    [TestClass]
    public partial class EngineeringMaintenanceServiceTests : TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        int Add()
        {
            var expectedDto = new EngineeringMaintenanceDTO() 
            {
                Name = "柜子",
                Position = "万寿楼",                
                LocationId = 1517,
                RepairLocationId = 1559,
                CompletionBeginTime = DateTime.Now.AddDays(-5),
                CompletionEndTime = DateTime.Now.AddDays(-4),
                LsStatus = 2,
                Memo = "",
                OperId = 9,
                OperTime = DateTime.Now
            };

            var response = ServiceWrapper.Invoke<IEngineeringMaintenanceService, EngineeringMaintenanceDTO>(x => x.Add(expectedDto));
            
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsNotNull(response.Result);
            Assert.AreNotEqual(0, response.Result.ID);          

            return response.Result.ID;
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
            var response = ServiceWrapper.Invoke<IEngineeringMaintenanceService, IEnumerable<EngineeringMaintenanceDTO>>(x => x.GetAll());
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsTrue(response.Result.Where(x => x.ID == ID).Any());
        }

        [TestMethod]
        public void Test_GetById()
        {
            int ID = Add();
            var getResponse = ServiceWrapper.Invoke<IEngineeringMaintenanceService, EngineeringMaintenanceDTO>(x => x.GetById(ID));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsNotNull(getResponse.Result);
        }

        [TestMethod]
        public void Test_Update()
        {
            int ID = Add();
            var getResponse = ServiceWrapper.Invoke<IEngineeringMaintenanceService, EngineeringMaintenanceDTO>(x => x.GetById(ID));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsNotNull(getResponse.Result);

            var dto = getResponse.Result;
            dto.Memo = "数据更新测试...";
            dto.OperId = 6768;

            var updateResponse = ServiceWrapper.Invoke<IEngineeringMaintenanceService, int>(x => x.Update(dto));
            Assert.IsTrue(updateResponse.Status == ResponseStatus.OK);
            Assert.AreEqual(1, updateResponse.Result);
        }

        [TestMethod]
        public void Test_Delete()
        {
            int ID = Add();
            var getResponse = ServiceWrapper.Invoke<IEngineeringMaintenanceService, EngineeringMaintenanceDTO>(x => x.GetById(ID));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);

            EngineeringMaintenanceDTO dto = getResponse.Result;
            Assert.IsNotNull(dto);

            var deleteResponse = ServiceWrapper.Invoke<IEngineeringMaintenanceService, int>(x => x.Delete(dto));
            Assert.IsTrue(deleteResponse.Status == ResponseStatus.OK);
            Assert.AreEqual(1, deleteResponse.Result);
        }

        [TestMethod]
        public void Test_AddOrUpdate()
        {
            var getResponse = ServiceWrapper.Invoke<IEngineeringMaintenanceService, IEnumerable<EngineeringMaintenanceDTO>>(x => x.GetAll().Where(y => y.OperId != 6768));

            List<EngineeringMaintenanceDTO> addDTOs = new List<EngineeringMaintenanceDTO>();
            addDTOs.Add(new EngineeringMaintenanceDTO()
            {
                Name = "空调",
                Position = "松鹤北",
                LocationId = 1517,
                RepairLocationId = 1559,
                CompletionBeginTime = DateTime.Now.AddDays(-5),
                CompletionEndTime = null,
                LsStatus = 1,
                Memo = "",
                OperId = 9,
                OperTime = DateTime.Now
            });

            addDTOs.Add(new EngineeringMaintenanceDTO()
            {
                Name = "电风扇",
                Position = "松鹤南",
                LocationId = 1517,
                RepairLocationId = 1559,
                CompletionBeginTime = DateTime.Now.AddDays(-5),
                CompletionEndTime = null,
                LsStatus = 1,
                Memo = "",
                OperId = 9,
                OperTime = DateTime.Now
            });

            List<EngineeringMaintenanceDTO> addOrUpdateDTOs = new List<EngineeringMaintenanceDTO>();
            var updateDTOs = getResponse.Result.Where(x => x.OperId == 9).ToList();
            updateDTOs.ForEach(x =>
            {
                x.Memo = "AddOrUpdate 测试 ....";
            });

            addOrUpdateDTOs.AddRange(addDTOs);
            addOrUpdateDTOs.AddRange(updateDTOs);

            var updateResponse = ServiceWrapper.Invoke<IEngineeringMaintenanceService, Tuple<int, int>>(x => x.AddOrUpdate(addOrUpdateDTOs));
            Assert.IsTrue(updateResponse.Status == ResponseStatus.OK);
            Assert.AreEqual(addDTOs.Count, updateResponse.Result.Item1);
            Assert.AreEqual(updateDTOs.Count, updateResponse.Result.Item2);
        }        

         [TestMethod]
        public void Test_GetByLambdaExpression()
        {
            var getResponse = ServiceWrapper.Invoke<IEngineeringMaintenanceService, IEnumerable<EngineeringMaintenanceDTO>>(x => x.Get(y => y.Name.Contains("柜子") || y.Memo.Contains("柜子") || y.Position.Contains("万寿楼")));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsTrue(getResponse.Result.Count() > 0);
        }
    }
}