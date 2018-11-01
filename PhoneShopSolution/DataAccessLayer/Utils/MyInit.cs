using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Utils
{
    public class MyInit : DropCreateDatabaseIfModelChanges<Context>
    {

        protected override void Seed(Context context)
        {
            context.Phones.Add(new Phone() { Brand = "Apple", Model = "Iphone X", Price = 1000 });
            context.Database.ExecuteSqlCommand("insert int Phones ");
        }
    }
}
