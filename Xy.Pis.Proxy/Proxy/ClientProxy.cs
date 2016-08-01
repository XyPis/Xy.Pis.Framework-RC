using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.ServiceModel;
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
            ChannelFactory<TContract> ChannelFactory = new ChannelFactory<TContract>(EndpointConfigurationName);
            if (Credentials)
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);

                var clientCredentials = ChannelFactory.Credentials;
                clientCredentials.UserName.UserName = UserName;
                clientCredentials.UserName.Password = Password;
            }

            return ChannelFactory.CreateChannel();
        }
    }
}



