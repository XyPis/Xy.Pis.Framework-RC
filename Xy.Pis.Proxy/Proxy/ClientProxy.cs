using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks; 
using log4net;

namespace Xy.Pis.Proxy
{
    public class ClientProxy
    {
        protected string EndpointConfigurationName
        {
            get { return "BasicHttpBinding_IService1"; }
        }

        protected virtual string UserName { get; private set; }

        protected virtual string Password { get; private set; }

        protected virtual bool Credentials { get; private set; }

        public TContract GetContract<TContract>()
        {
            ChannelFactory<TContract> channelFactory = new ChannelFactory<TContract>(this.EndpointConfigurationName);
            if (this.Credentials)
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                var clientCredentials = channelFactory.Credentials;
                clientCredentials.UserName.UserName = this.UserName;
                clientCredentials.UserName.Password = this.Password;
            }

            return channelFactory.CreateChannel();
        }
    }
}