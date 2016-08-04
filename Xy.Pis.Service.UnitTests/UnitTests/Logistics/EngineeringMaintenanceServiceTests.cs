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
                FacilityName = "柜子",
                LocationName = "万寿楼",                
                LocationId = 1517,
                ResponsiblityLocId = 1559,
                ETC = DateTime.Now.AddDays(-5),
                ATC = DateTime.Now.AddDays(-4),
                Status = 2,
                Remark = "",
                OperId = 9,
                OperTime = DateTime.Now
            };

            var response = engineeringMaintenanceService.Invoke(x => x.Add(expectedDto));
            
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
            var response = engineeringMaintenanceService.Invoke(x => x.GetAll());
            Assert.IsTrue(response.Status == ResponseStatus.OK);
            Assert.IsTrue(response.Result.Where(x => x.Id == ID).Any());
        }

        [TestMethod]
        public void Test_GetById()
        {
            int ID = Add();
            var getResponse = engineeringMaintenanceService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsNotNull(getResponse.Result);
        }

        [TestMethod]
        public void Test_Update()
        {
            int ID = Add();
            var getResponse = engineeringMaintenanceService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);
            Assert.IsNotNull(getResponse.Result);

            var dto = getResponse.Result;
            dto.Remark = "数据更新测试...";
            dto.OperId = 6768;

            var updateResponse = engineeringMaintenanceService.Invoke(x => x.Update(dto));
            Assert.IsTrue(updateResponse.Status == ResponseStatus.OK);
            Assert.AreEqual(1, updateResponse.Result);
        }

        [TestMethod]
        public void Test_Delete()
        {
            int ID = Add();
            var getResponse = engineeringMaintenanceService.Invoke(x => x.GetById(ID));
            Assert.IsTrue(getResponse.Status == ResponseStatus.OK);

            EngineeringMaintenanceDTO dto = getResponse.Result;
            Assert.IsNotNull(dto);

            var deleteResponse = engineeringMaintenanceService.Invoke(x => x.Delete(dto));
            Assert.IsTrue(deleteResponse.Status == ResponseStatus.OK);
            Assert.AreEqual(1, deleteResponse.Result);
        }

        [TestMethod]
        public void Test_AddOrUpdate()
        {
            var getResponse = engineeringMaintenanceService.Invoke(x => x.GetAll().Where(y => y.OperId != 6768));

            List<EngineeringMaintenanceDTO> addDTOs = new List<EngineeringMaintenanceDTO>();
            addDTOs.Add(new EngineeringMaintenanceDTO()
            {
                FacilityName = "空调",
                LocationName = "松鹤北",
                LocationId = 1517,
                ResponsiblityLocId = 1559,
                ETC = DateTime.Now.AddDays(-5),
                ATC = null,
                Status = 1,
                Remark = "",
                OperId = 9,
                OperTime = DateTime.Now
            });

            addDTOs.Add(new EngineeringMaintenanceDTO()
            {
                FacilityName = "电风扇",
                LocationName = "松鹤南",
                LocationId = 1517,
                ResponsiblityLocId = 1559,
                ETC = DateTime.Now.AddDays(-5),
                ATC = null,
                Status = 1,
                Remark = "",
                OperId = 9,
                OperTime = DateTime.Now
            });

            List<EngineeringMaintenanceDTO> addOrUpdateDTOs = new List<EngineeringMaintenanceDTO>();
            var updateDTOs = getResponse.Result.Where(x => x.OperId == 9).ToList();
            updateDTOs.ForEach(x =>
            {
                x.Remark = "AddOrUpdate 测试 ....";
            });

            addOrUpdateDTOs.AddRange(addDTOs);
            addOrUpdateDTOs.AddRange(updateDTOs);

            var updateResponse = engineeringMaintenanceService.Invoke(x => x.AddOrUpdate(addOrUpdateDTOs));
            Assert.IsTrue(updateResponse.Status == ResponseStatus.OK);
            Assert.AreEqual(addDTOs.Count, updateResponse.Result.Item1);
            Assert.AreEqual(updateDTOs.Count, updateResponse.Result.Item2);
        }        
    }
}