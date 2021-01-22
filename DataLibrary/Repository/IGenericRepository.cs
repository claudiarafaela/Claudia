using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public interface IGenericRepository<T> where T : class 
    {
        List<T> GetAll();
        T GetById(int Id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(object Id);

    }
}
