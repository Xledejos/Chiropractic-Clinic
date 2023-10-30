using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiropracticClinic.DataAccess.Repository.IRepository
{
    public interface IGenericRepository<T, Guid>
    {
        Task Insert(T entity);
        Task<T?> GetById(Guid id);
        IQueryable<T> GetAll();
        void Delete(T entity);
    }
}
