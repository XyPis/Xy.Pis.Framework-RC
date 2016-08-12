using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Xy.Pis
{
    [DataContract]
    public abstract class DTOBase //: Model.absModel
    {
        [DataMember]
        public int ID { get; set; }

        //public override void Fill(System.Data.IDataReader datareader)
        //{
        //}
    }
}
