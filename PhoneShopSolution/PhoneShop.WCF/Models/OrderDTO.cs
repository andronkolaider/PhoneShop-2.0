using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.WCF.Models { //datacontract datamember

    [DataContract]
    public class OrderDTO {

        [DataMember]
        public int      Id          { get; set; }
        [DataMember]
        public PhoneDTO Phone       { set; get; }
        [DataMember]
        public OrderDTO Order       { set; get; }
        [DataMember]
        public DateTime dateTime    { set; get; }

    }
}
