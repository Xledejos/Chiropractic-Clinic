using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiropracticClinic.DataAccess.Repository.IRepository
{
    public interface IGenericRepository<T>
    {
        Task<T> Get(T entity);
        Task<T> GetById(Guid id);
        IQueryable<T> GetAll();
        void Update(T entity);
        Task<bool> Delete(Guid id);
    }
}
