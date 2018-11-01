using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.WCF.Models {

    [DataContract]
    public class PhoneDTO {

        [DataMember]
        public int      Id        { set; get; }
        [DataMember]
        public string   Brand     { set; get; }
        [DataMember]
        public string   Model     { set; get; }
        [DataMember]
        public double   Price     { set; get; }

    }
}
