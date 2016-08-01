using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using log4net;

namespace Xy.Pis.Proxy.UnitTests
{
    [TestClass]
    public class TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [AssemblyInitialize]
        public static void Test_Initialize(TestContext context) 
        {
            //Log.DebugFormat("Log is debug enabled: {0}", Log.IsDebugEnabled);
            //Log.DebugFormat("Client Service Proxy Initialize ..........");
            //Initializer.Init();
        }
    }
} 
 
