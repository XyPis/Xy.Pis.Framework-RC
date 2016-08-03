using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ServiceModel;
using System.Diagnostics;
using log4net;
using Xy.Pis.Contract.Service;

namespace Xy.Pis.Proxy
{
    public static class ProxyExtensions
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static Response<String> Invoke<TContract>(this TContract proxy, Action<TContract> action)
            where TContract : IServiceBase
        {
            bool isRemoteService = IsRemoteService(proxy);
            var st = new Stopwatch();
            if (Log.IsDebugEnabled)
            {
                st.Start();
                Log.InfoFormat("Request to {0} service {1} ......", (isRemoteService ? "remote" : "local"), typeof(TContract));
                Log.InfoFormat("Client Method: {0}", action.Method);
            }
            
            var response = isRemoteService 
                ? InvokeRemoteService(proxy, action) 
                : InvokeLocalService(proxy, action);
            

            if (Log.IsDebugEnabled)
            {
                st.Stop();
                Log.DebugFormat("Request done in {0} ms.", st.ElapsedMilliseconds);
            }            

            return response;
        }

        public static Response<TResult> Invoke<TContract, TResult>(this TContract proxy, Func<TContract, TResult> func)
            where TContract : IServiceBase
        {
            bool isRemoteService = IsRemoteService(proxy);
            
            var st = new Stopwatch();
            
            if (Log.IsDebugEnabled)
            {
                st.Start();
                Log.InfoFormat("Request to {0} service {1} ......", (isRemoteService ? "remote" : "local"), typeof(TContract));
                Log.InfoFormat("Client Method: {0}", func.Method);
            }                        
            
            var response = isRemoteService
                ? InvokeRemoteService(proxy, func) 
                : InvokeLocalService(proxy, func);

            if (Log.IsDebugEnabled)
            {
                st.Stop();
                Log.DebugFormat("Request done in {0} ms.", st.ElapsedMilliseconds);
            }

            return response;
        }

        static bool IsRemoteService<TContract>(TContract proxy)
            where TContract : IServiceBase
        {
            return (proxy as IClientChannel) != null ? true : false;
        }

        private static Response<String> InvokeLocalService<TContract>(TContract proxy, Action<TContract> action)
             where TContract : IServiceBase
        {
            Response<String> result = new Response<String>()
            {
                Status = ResponseStatus.Error,
                Message = "Unknow Error",
                Result = String.Empty,
                ServiceType = ServiceType.Local,
            };

            try
            {
                action(proxy);
                result.Status = ResponseStatus.OK;
                result.Message = string.Empty;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                LogWriter("Exception", ex);
            }            
            
            return result;
        }

        private static Response<TResult> InvokeLocalService<TContract, TResult>(TContract proxy, Func<TContract, TResult> func)
             where TContract : IServiceBase
        {
            Response<TResult> result = new Response<TResult>()
            {
                Status = ResponseStatus.Error,
                Message = "Unknow Error",
                Result = default(TResult),
                ServiceType = ServiceType.Local,
            };

            try
            {
                result.Result = func(proxy);
                result.Status = ResponseStatus.OK;
                result.Message = string.Empty;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                LogWriter("Exception", ex);
            }
                      
            return result;
        }

        static void LogWriter(string type, Exception ex)
        {
            if (ex != null)
            {
                if (string.IsNullOrEmpty(type))
                    type = "Exception";

                Log.ErrorFormat("{2}: {0} \n{1}", ex.Message, ex.StackTrace, type);
                if (ex.InnerException != null)
                    Log.ErrorFormat("InnerException: {0} \n{1}", ex.InnerException.Message, ex.InnerException.StackTrace);
            }
        }

        private static Response<String> InvokeRemoteService<TContract>(TContract proxy, Action<TContract> action)
             where TContract : IServiceBase
        {
            Response<String> result = new Response<String>()
            {
                Status = ResponseStatus.Error,
                Message = "Unknow Error",
                Result = String.Empty,
                ServiceType = ServiceType.Remote,
            };

            try
            {
                action(proxy);
                (proxy as IClientChannel).Close();
                result.Status = ResponseStatus.OK;
                result.Message = string.Empty;
            }
            catch (System.ServiceModel.CommunicationException ce)
            {
                (proxy as IClientChannel).Abort();
                result.Message = ce.Message;

                LogWriter("CommunicationException", ce);
            }
            catch (TimeoutException te)
            {
                (proxy as IClientChannel).Abort();
                result.Message = te.Message;

                LogWriter("CommunicationException", te);
            }
            catch (Exception ex)
            {
                (proxy as IClientChannel).Abort();
                result.Message = ex.Message;

                LogWriter("Exception", ex);
                //throw;
            }

            return result;
        }
       
        private static Response<TResult> InvokeRemoteService<TContract, TResult>(TContract proxy, Func<TContract, TResult> func)
             where TContract : IServiceBase
        {
            Response<TResult> result = new Response<TResult>() 
            {
                Status = ResponseStatus.Error,
                Message = "Unknow Error",
                Result = default(TResult),
                ServiceType = ServiceType.Remote,
            };

            try
            {
                result.Result = func(proxy);
                (proxy as IClientChannel).Close();
                result.Status = ResponseStatus.OK;
                result.Message = string.Empty;
            }
            catch (System.ServiceModel.CommunicationException ce)
            {                
                (proxy as IClientChannel).Abort();
                result.Message = ce.Message;

                LogWriter("CommunicationException", ce);
            }
            catch (TimeoutException te)
            {
                (proxy as IClientChannel).Abort();
                result.Message = te.Message;

                LogWriter("TimeoutException", te);
            }
            catch (Exception ex)
            {
                (proxy as IClientChannel).Abort();
                result.Message = ex.Message;

                LogWriter("Exception", ex);                
                //throw;
            }

            return result;
        }
    }

}
