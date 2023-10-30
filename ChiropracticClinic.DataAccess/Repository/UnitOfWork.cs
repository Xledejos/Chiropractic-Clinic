using ChiropracticClinic.Data;
using ChiropracticClinic.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiropracticClinic.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IProductoRepository Producto { get; init; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Producto = new ProductoRepository(_context);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
