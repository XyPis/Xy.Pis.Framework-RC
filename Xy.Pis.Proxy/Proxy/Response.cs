using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xy.Pis.Proxy
{
    public class Response<T>
    {
        public ResponseStatus Status { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }

        public ServiceType ServiceType { get; set; }

    }

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
}
