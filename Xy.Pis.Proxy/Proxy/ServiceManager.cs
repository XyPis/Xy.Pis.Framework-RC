using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using log4net;
using Xy.Pis.Contract.Service;

namespace Xy.Pis.Proxy
{
    public class ServiceManager
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static Type[] _remoteService = new Type[]
        {
           //typeof(IAdditionalMealService)
        };

        public static T GetService<T>() where T : IServiceBase
        {
            try
            {
                ServiceType type = ServiceType.Local;

                if (_remoteService.Where(t => t == typeof(T)).Any())
                {
                    type = ServiceType.Remote;
                }

                return (type == ServiceType.Local) ? GetLocalService<T>() : GetRemoteService<T>();
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("GetService<{0}> Exception: {1} \n{2}", typeof(T), ex.Message, ex.StackTrace);
                throw;
            }
        }

        private static T GetLocalService<T>() where T : IServiceBase
        {
            return Common.Unity.IoC.Resolve<T>();
        }

        private static T GetRemoteService<T>() where T : IServiceBase
        {
            ClientProxy proxy = new ClientProxy();
            return proxy.GetContract<T>();
        }
    }
}
