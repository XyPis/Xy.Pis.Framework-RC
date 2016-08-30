using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xy.Pis.Proxy
{
    public enum ResponseStatus
    {
        OK = 0,
        Error = 1,
    }

    public enum ServiceType
    {
        Local = 0,
        Remote = 1,
    }

    public class Response<T>
    {
        public Response()
        {
            this.Status = ResponseStatus.OK;
            this.Message = string.Empty;
            this.Result = default(T);
        }

        public Response(ServiceType serviceType)
        {
            this.Status = ResponseStatus.OK;
            this.Message = string.Empty;
            this.ServiceType = serviceType;
            this.Result = default(T);
        }

        public ResponseStatus Status { get; set; }

        public string Message { get; set; }
        
        public T Result { get; set; }

        public ServiceType ServiceType { get; set; }
    }   
}
