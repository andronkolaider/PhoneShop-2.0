using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShopWPF
{
    public class Order
    {
        public int ID { set; get; }
        public  Phone phone { set;get;}
        public  User user { set; get;}
        public DateTime dateTime { set; get;}
     }   
}

