using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using log4net;
using Microsoft.Practices.Unity;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Core;
using Xy.Pis.Utils.AutoMapper;
using Xy.Pis.Utils.Unity;

namespace Xy.Pis.Service
{
    public class Initializer
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
       
        public static void Init(string connectionString, params Type[] excludeTypes)
        {
            Core.Initializer.Init<XyDbContext>(connectionString);
            
            var fromAssembly = typeof(IAdditionalMealService).Assembly;
            var toAssembly = typeof(Logistics.AdditionalMealService).Assembly;
            
            IoC.RegisterType(fromAssembly, toAssembly, excludeTypes);

            AutoMapperBootStrapper.Initialize(new Assembly[]
            {
                typeof(Logistics.AdditionalMealService).Assembly
            });

            IoC.RegisterType<ICommandWrapper, CommandWrapper>();
        }
    }
}