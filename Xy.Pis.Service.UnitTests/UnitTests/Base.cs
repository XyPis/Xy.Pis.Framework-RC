using System;
using System.Reflection;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
