using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Xy.Pis
{
    [DataContract]
    public abstract class DTOBase
    {
        [DataMember]
        public int ID { get; set; }
    }
}
