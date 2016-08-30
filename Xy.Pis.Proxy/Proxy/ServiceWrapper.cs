using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using log4net;
using Xy.Pis.Contract.Service;
using Xy.Pis.Utils.Exceptions;
using Xy.Pis.Utils.Unity;

namespace Xy.Pis.Proxy
{
    public class ServiceWrapper
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static Type[] remoteService = new Type[]
        {
           // typeof(IAdditionalMealService)
        };

        private enum EnumExeptionType
        {
            Exception = 0,
            TimeoutException = 1,
            CommunicationException = 2,
        }

        public static Response<string> Invoke<T>(Action<T> action)
            where T : IServiceBase
        {
            T proxy = GetService<T>();

            bool isRemoteService = IsRemoteService(proxy);

            var st = new Stopwatch();
            if (Log.IsDebugEnabled)
            {
                st.Start();
                Log.DebugFormat("Request to {0} service {1} ......", isRemoteService ? "remote" : "local", typeof(T));
                Log.DebugFormat("Client Method: {0}", action.Method);
            }

            var response = isRemoteService ? InvokeRemoteService(proxy, action) : InvokeLocalService(proxy, action);

            if (Log.IsDebugEnabled)
            {
                st.Stop();
                Log.DebugFormat("Request done in {0} ms.", st.ElapsedMilliseconds);
            }

            return response;
        }

        public static Response<TResult> Invoke<T, TResult>(Func<T, TResult> func)
            where T : IServiceBase
        {
            T proxy = GetService<T>();
            bool isRemoteService = IsRemoteService(proxy);

            var st = new Stopwatch();

            if (Log.IsDebugEnabled)
            {
                st.Start();
                Log.DebugFormat("Request to {0} service {1} ......", isRemoteService ? "remote" : "local", typeof(T));
                Log.DebugFormat("Client Method: {0}", func.Method);
            }

            var response = isRemoteService ? InvokeRemoteService(proxy, func) : InvokeLocalService(proxy, func);

            if (Log.IsDebugEnabled)
            {
                st.Stop();
                Log.DebugFormat("Request done in {0} ms.", st.ElapsedMilliseconds);
            }

            return response;
        }

        private static T GetService<T>()
            where T : IServiceBase
        {
            try
            {
                ServiceType type = ServiceType.Local;

                if (remoteService.Where(t => t == typeof(T)).Any())
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

        private static T GetLocalService<T>()
            where T : IServiceBase
        {
            return IoC.Resolve<T>();
        }

        private static T GetRemoteService<T>()
            where T : IServiceBase
        {
            ClientProxy proxy = new ClientProxy();
            return proxy.GetContract<T>();
        }

        private static bool IsRemoteService<T>(T service)
            where T : IServiceBase
        {
            return (service as IClientChannel) != null ? true : false;
        }

        private static Response<string> InvokeLocalService<T>(T proxy, Action<T> action)
          where T : IServiceBase
        {
            Response<string> result = new Response<string>(ServiceType.Local);

            try
            {
                action(proxy);
            }
            catch (Exception ex)
            {
                result.Status = ResponseStatus.Error;
                result.Message = GetErrMessage(ex, EnumExeptionType.Exception);
                Log.Error(result.Message);
            }

            return result;
        }

        private static Response<TResult> InvokeLocalService<T, TResult>(T proxy, Func<T, TResult> func)
             where T : IServiceBase
        {
            Response<TResult> result = new Response<TResult>(ServiceType.Local);

            try
            {
                result.Result = func(proxy);
            }
            catch (Exception ex)
            {
                result.Status = ResponseStatus.Error;

                result.Message = GetErrMessage(ex, EnumExeptionType.Exception);
                Log.Error(result.Message);
            }

            return result;
        }

        private static Response<string> InvokeRemoteService<T>(T proxy, Action<T> action)
             where T : IServiceBase
        {
            Response<string> result = new Response<string>(ServiceType.Remote);
            ResponseStatus responseStatus = ResponseStatus.Error;
            string message = string.Empty;

            try
            {
                action(proxy);
                (proxy as IClientChannel).Close();
                responseStatus = ResponseStatus.OK;
            }
            catch (System.ServiceModel.CommunicationException ce)
            {
                message = GetErrMessage(ce, EnumExeptionType.CommunicationException);
            }
            catch (TimeoutException te)
            {
                message = GetErrMessage(te, EnumExeptionType.TimeoutException);
            }
            catch (Exception ex)
            {
                message = GetErrMessage(ex, EnumExeptionType.Exception);
            }
            finally
            {
                result.Status = responseStatus;
                result.Message = message;
                if (result.Status == ResponseStatus.Error)
                {
                    Log.Error(result.Message);

                    try
                    {
                        (proxy as IClientChannel).Abort();
                    }
                    catch (Exception e)
                    {
                        Log.Error(e.Message);
                    }
                }
            }

            return result;
        }

        private static Response<TResult> InvokeRemoteService<T, TResult>(T proxy, Func<T, TResult> func)
             where T : IServiceBase
        {
            Response<TResult> result = new Response<TResult>(ServiceType.Remote);
            ResponseStatus responseStatus = ResponseStatus.Error;
            string message = string.Empty;

            try
            {
                result.Result = func(proxy);
                (proxy as IClientChannel).Close();
                responseStatus = ResponseStatus.OK;
            }
            catch (System.ServiceModel.CommunicationException ce)
            {
                message = GetErrMessage(ce, EnumExeptionType.CommunicationException);
            }
            catch (TimeoutException te)
            {
                message = GetErrMessage(te, EnumExeptionType.TimeoutException);
            }
            catch (Exception ex)
            {
                message = GetErrMessage(ex, EnumExeptionType.Exception);
            }
            finally
            {
                result.Status = responseStatus;
                result.Message = message;
                if (result.Status == ResponseStatus.Error)
                {
                    Log.Error(result.Message);
                    try
                    {
                        (proxy as IClientChannel).Abort();
                    }
                    catch (Exception e)
                    {
                        Log.Error(e.Message);
                    }
                }
            }

            return result;
        }

        private static string GetErrMessage(Exception ex, EnumExeptionType exeptionType)
        {
            string errMessage = string.Empty;
            Exception innerException = ex.GetInnerException();
            if (innerException != null)
            {
                errMessage = string.Format("{0}: {1} \n{2}", exeptionType.ToString(), innerException.Message, ex.StackTrace);
            }

            return errMessage;
        }       
    }
}
