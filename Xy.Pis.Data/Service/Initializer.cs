using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.Practices.Unity;
using log4net;
using Xy.Pis.Contract.Service.Logistics;
using Xy.Pis.Core;

namespace Xy.Pis.Service
{
    public class Initializer
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
       
        public static void Init(params Type[] excludeTypes)
        {
            Core.EF.Initializer.Init<XyDbContext>();
            
            var fromAssembly = typeof(IAdditionalMealService).Assembly;
            var toAssembly = typeof(Logistics.AdditionalMealService).Assembly;
            
            Common.Unity.IoC.RegisterType(fromAssembly, toAssembly, excludeTypes);

            Common.AutoMapper.AutoMapperBootStrapper.Initialize(new Assembly[]
            {
                typeof(Logistics.AdditionalMealService).Assembly
            });
            Common.Unity.IoC.RegisterType<ICommandWrapper, CommandWrapper>();
        }
    }
}