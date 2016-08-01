using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.Practices.Unity;
using log4net;
using System.Reflection;
using Xy.Pis.DataContract.Logistics;
using Xy.Pis.ServiceContract.Logistics;

namespace Xy.Pis.Service.UnitTests.Logistics
{
    [TestClass]
    public class DailyMenuServiceUnitTests : TestBase
    {        
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);       
     
        [TestMethod]
        public void Test_GetMenuByType_Return_Empty()
        {
            int type = 999999;
            var menuList = dailyMenuService.GetMenuListByType(type);
            Assert.IsNotNull(menuList);
            Assert.IsTrue(!menuList.Any());
        }

        [TestMethod]
        public void Test_GetMenuByType_Return_Ok()
        {
            int type = 0;
            var menuList = dailyMenuService.GetMenuListByType(type);
            
            Assert.IsNotNull(menuList);
            Assert.IsTrue(menuList.Any());
        }

        [TestMethod]
        public void Tests_Retrieve_Return_Ok()
        {
            //int type = 0;
            //var menuList = dailyMenuService.Retrieve(x => x.Type == type);
            
            //Assert.IsNotNull(menuList);
            //Assert.IsTrue(menuList.Any());
        }
    }
}