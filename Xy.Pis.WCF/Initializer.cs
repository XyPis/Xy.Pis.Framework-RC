using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Reflection;
using log4net;
using System.Data.Entity;
using Xy.Pis.Contract.Service;
using Xy.Pis.Service;

namespace Xy.Pis.WCF
{
    public class Initializer
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Init()
        {
            Common.Unity.IoC.RegisterType(typeof(IUoWService<>).Assembly, typeof(UoWService<,>).Assembly);
        }
    }
}