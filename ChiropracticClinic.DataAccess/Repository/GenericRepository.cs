using ChiropracticClinic.Data;
using ChiropracticClinic.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ChiropracticClinic.Models.Repository
{
    public class GenericRepository<T, Guid> : IGenericRepository<T, Guid>
        where T : class
        where Guid : IEquatable<Guid>
    {
        private readonly ApplicationDbContext _context;
        protected DbSet<T> Entities => _context.Set<T>();

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Insert(T entity)
        {
            await Entities.AddAsync(entity);
        }

        public async Task<T?> GetById(Guid id)
            => await Entities.FirstOrDefaultAsync();

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
