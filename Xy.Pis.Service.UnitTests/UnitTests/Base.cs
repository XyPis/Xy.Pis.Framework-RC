using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;

namespace Xy.Pis.Service.UnitTests
{
    [TestClass]
    public class Base
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [AssemblyInitialize]
        public static void Test_Initialize(TestContext context) 
        {
            string connectionString = "test";

            Initializer.Init(connectionString);
        }
    }
}
