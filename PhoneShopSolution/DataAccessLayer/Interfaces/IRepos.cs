using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface  IRepos<T> where T:class 
    {
        IEnumerable<T> GetAll();
        T GetElementById(int ID);
        void Create(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
