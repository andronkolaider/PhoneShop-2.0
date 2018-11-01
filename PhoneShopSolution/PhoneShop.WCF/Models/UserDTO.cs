using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.WCF.Models {

    [DataContract]
    public class UserDTO {

        [DataMember]
        public int      Id      { get; set; }
        [DataMember]
        public string   Name    { set; get; }
        [DataMember]
        public string   Email   { set; get; }

    }
}
