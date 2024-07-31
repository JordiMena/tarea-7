using ControlDelInventario.Domain.Entities;
using ControlDelInventario.Domain.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ControlDelInventario.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _context;

        public ProductoRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Producto GetById(int id)
        {
            return _context.Productos.Find(id);
        }

        public IEnumerable<Producto> GetAll()
        {
            return _context.Productos.ToList();
        }

        public void Add(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void Update(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}
