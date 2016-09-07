using System;
using System.Reflection;
using log4net;
using Xunit;

namespace Xy.Pis.Proxy.UnitTests
{    
    public class TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public TestBase()
        {
            ////Log.DebugFormat("Log is debug enabled: {0}", Log.IsDebugEnabled);
            ////Log.DebugFormat("Client Service Proxy Initialize ..........");
            ////Initializer.Init();
        }     
    }
}