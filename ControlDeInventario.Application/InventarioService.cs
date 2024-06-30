using Proyecto.Domain.Entities;
using Proyecto.Domain.Repository;
using System.Collections.Generic;

namespace Proyecto.Application.Services
{
    public class InventarioService
    {
        private readonly IProductoRepository _productoRepository;

        public InventarioService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public IEnumerable<Producto> ListarProductos()
        {
            return _productoRepository.GetAll();
        }

        public Producto ObtenerProducto(int id)
        {
            return _productoRepository.GetById(id);
        }

        public void AgregarProducto(Producto producto)
        {
            _productoRepository.Add(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            _productoRepository.Update(producto);
        }

        public void EliminarProducto(int id)
        {
            _productoRepository.Delete(id);
        }
    }
}
