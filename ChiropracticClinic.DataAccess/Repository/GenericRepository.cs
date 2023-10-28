using ChiropracticClinic.Data;
using ChiropracticClinic.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ChiropracticClinic.Models.Repository
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        private readonly ApplicationDbContext _context;
        protected DbSet<T> Entities => _context.Set<T>();

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
