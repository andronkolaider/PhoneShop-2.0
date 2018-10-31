namespace DataAccessLayer.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        public Context()
            : base("name=connectionString")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}