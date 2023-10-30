using ChiropracticClinic.Data;
using ChiropracticClinic.DataAccess.Repository.IRepository;
using ChiropracticClinic.Models;
using ChiropracticClinic.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiropracticClinic.DataAccess.Repository
{
    public class ProductoRepository : GenericRepository<Producto, Guid>, IProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }

        public void Update(Producto producto)
        {
            var product = _context.Productos.FirstOrDefault(x => x.Id == producto.Id);

            if(product is not null)
            {
                product.Name = producto.Name;
                product.Description = producto.Description;
                product.Price = producto.Price;

                _context.SaveChanges();
            }
        }
    }
}
