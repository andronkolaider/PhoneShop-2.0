using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    [Table("Phones")]
    public class Phone
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
    }
}
