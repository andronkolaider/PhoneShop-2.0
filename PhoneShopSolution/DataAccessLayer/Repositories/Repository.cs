using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Repository<T> : IRepos<T> where T : class
    {
        private readonly Context db;
        private readonly DbSet<T> Collection;

        public Repository(Context _db)
        {
            db = _db;
            Collection = db.Set<T>();
        }

        public void Create(T Entity)
        {
            Collection.Add(Entity);
            db.SaveChanges();
        }

        public void Delete(T Entity)
        {
            Collection.Attach(Entity);
            Collection.Remove(Entity);
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return Collection.AsNoTracking<T>().AsEnumerable<T>();
        }

        public T GetElementById(int ID)
        {
            return Collection.Find(ID);
        }

        public void Update(T Entity)
        {
            db.Entry<T>(Entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
