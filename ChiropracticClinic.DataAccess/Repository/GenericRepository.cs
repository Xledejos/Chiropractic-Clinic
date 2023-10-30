using ChiropracticClinic.Data;
using ChiropracticClinic.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ChiropracticClinic.Models.Repository
{
    public abstract class GenericRepository<T, Guid> : IGenericRepository<T, Guid>
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
            => await Entities.FirstOrDefaultAsync(Guid => Guid.Equals(id));

        public IQueryable<T> GetAll()
         => Entities;

        public void Delete(T entity)
        {
            Entities.Remove(entity);
        }
    }
}
