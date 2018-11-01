using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Order
    {
        public int ID { get; set; }
        public Phone Phone { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
