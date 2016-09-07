using System;
using System.Reflection;
using log4net;

namespace Xy.Pis.Service.UnitTests
{    
    public class Base
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public Base()
        {
            string connectionString = "testdbContext";

            Initializer.Init(connectionString);
        }
    }
}
