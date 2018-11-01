namespace DataAccessLayer.Models
{
    using DataAccessLayer.Utils;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        public Context()
            : base("name=connectionString")
        {
            Database.SetInitializer(new MyInit());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}