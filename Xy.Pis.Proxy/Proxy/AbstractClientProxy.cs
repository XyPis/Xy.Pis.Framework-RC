using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.ServiceModel;
using log4net;

namespace Xy.Pis.Proxy
{   
    public abstract class AbstractClientProxy<TContract> where TContract : class
    {
        protected abstract string EndpointConfigurationName { get; }
        protected virtual string UserName { get; private set; }
        protected virtual string Password { get; private set; }
        protected virtual bool Credentials { get; private set; }

        private ServiceProxy GetInstance()
        {
            return new ServiceProxy(this);
        }

        protected TResult InvokeService<TResult>(Func<TContract, TResult> func)
        {
            var clientProxy = this.GetInstance();

            return clientProxy.InvokeService<TResult>(func);
        }

        protected void InvokeService(Action<TContract> action)
        {
            var clientProxy = this.GetInstance();
            clientProxy.InvokeService(action);
        }

        private class ServiceProxy : IDisposable
        {
            ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            private bool disposed = false;

            public ServiceProxy(AbstractClientProxy<TContract> abstractServiceProxy)
            {
                try
                {
                    this.ChannelFactory = new ChannelFactory<TContract>(abstractServiceProxy.EndpointConfigurationName);
                    if (abstractServiceProxy.Credentials)
                    {
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);

                        var clientCredentials = this.ChannelFactory.Credentials;
                        clientCredentials.UserName.UserName = abstractServiceProxy.UserName;
                        clientCredentials.UserName.Password = abstractServiceProxy.Password;
                    }

                    Proxy = this.ChannelFactory.CreateChannel();
                }
                catch (Exception ex) 
                {
                    Log.Error(ex.Message);
                    throw;
                }               
            }

            private ChannelFactory<TContract> ChannelFactory { get; set; }
            private TContract Proxy { get; set; }

            #region InvokeService
            public TResult InvokeService<TResult>(Func<TContract, TResult> func)
            {
                TResult result = default(TResult);
                try
                {
                    result = func(Proxy);
                    (Proxy as IClientChannel).Close();
                }
                catch (CommunicationException ce)
                {
                    Log.ErrorFormat("Communication Exception: {0} {1}", ce.Message, ce.StackTrace);
                    (Proxy as IClientChannel).Abort();
                }
                catch (TimeoutException te)
                {                    
                    Log.ErrorFormat("Timeout Exception: {0} {1}", te.Message, te.StackTrace);
                    (Proxy as IClientChannel).Abort();
                }
                catch (Exception ex)
                {                    
                    Log.ErrorFormat("Unknown Exception: {0} {1}", ex.Message, ex.StackTrace);
                    (Proxy as IClientChannel).Close();
                    throw;
                }

                return result;
            }

            public void InvokeService(Action<TContract> action)
            {
                try
                {
                    action(Proxy);
                    (Proxy as IClientChannel).Close();
                }
                catch (CommunicationException ce)
                {
                    (Proxy as IClientChannel).Abort();
                    Log.ErrorFormat("Communication Exception: {0} {1}", ce.Message, ce.StackTrace);
                }
                catch (TimeoutException te)
                {
                    (Proxy as IClientChannel).Abort();
                    Log.ErrorFormat("Timeout Exception: {0} {1}", te.Message, te.StackTrace);
                }
                catch (Exception ex)
                {
                    (Proxy as IClientChannel).Close();
                    Log.ErrorFormat("Unknown Exception: {0} {1}", ex.Message, ex.StackTrace);
                }
            }
            #endregion InvokeService

            #region Dispose()
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            #endregion Dispose

            #region Dispose(bool)
            protected virtual void Dispose(bool disposing)
            {
                if (disposed)
                    return;

                if (disposing)
                {
                    if (Proxy != null)
                    {
                        try
                        {
                            (Proxy as IClientChannel).Close();
                        }
                        catch
                        { }
                    }

                    if (ChannelFactory != null)
                    {
                        try
                        {
                            ChannelFactory.Close();
                        }
                        catch
                        { }
                    }
                }

                disposed = true;
            }
            #endregion
        }

        #region CredentialConstants class
        internal class CredentialConstants
        {
            internal const string USER_NAME = "testadmin";
            internal const string PASSWORD = "testadmin";
        }
        #endregion
    }
}


