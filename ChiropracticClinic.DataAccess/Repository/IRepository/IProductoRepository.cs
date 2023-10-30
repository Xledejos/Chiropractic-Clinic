using ChiropracticClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiropracticClinic.DataAccess.Repository.IRepository
{
    public interface IProductoRepository : IGenericRepository<Producto>
    {
        void Update(Producto producto);
    }
}
