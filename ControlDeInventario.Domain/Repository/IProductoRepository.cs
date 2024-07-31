using ControlDelInventario.Domain.Entities;

namespace ControlDeInventario.Domain.Interfaces
{
    public interface IProductoRepository
    {
        Producto GetById(int id);
        IEnumerable<Producto> GetAll();
        void Add(Producto producto);
        void Update(Producto producto);
        void Delete(int id);
    }
}
