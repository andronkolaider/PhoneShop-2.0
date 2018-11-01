using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Utils
{
    public class MyInit : DropCreateDatabaseAlways<Context>
    {

        protected override void Seed(Context context)
        {
            context.Phones.Add(new Phone() { Brand = "Apple", Model = "Iphone X", Price = 1000 });
            context.Phones.Add(new Phone() { Brand = "Samsung", Model = "Galaxy S7", Price = 600 });
            context.Phones.Add(new Phone() { Brand = "Google", Model = "Pixel", Price = 420 });

            context.Users.Add(new User {  Name = "Andrii", EMail = "gaypornhere@gmail.com" });
            context.Users.Add(new User {  Name = "Vitalii", EMail = "fancytoys@gmail.com" });
            context.Users.Add(new User {  Name = "Gabe", EMail = "getblowjob@gmail.com" });

            context.SaveChanges();
        }
    }
}
