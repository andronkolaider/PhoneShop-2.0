using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace DALTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<User> repository = new Repository<User>(new Context());
            foreach (var item in repository.GetAll())
            {
                Console.WriteLine(item.Name + " " + item.EMail);
            }
        }
    }
}
