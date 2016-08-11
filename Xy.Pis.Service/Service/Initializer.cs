using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.Practices.Unity;
using log4net;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Core;
using Xy.Pis.Utils.Unity;
using Xy.Pis.Utils.AutoMapper;

namespace Xy.Pis.Service
{
    public class Initializer
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
       
        public static void Init(params Type[] excludeTypes)
        {
            Core.Initializer.Init<XyDbContext>();
            
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