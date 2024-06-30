using ControlDelInventario.Domain.Entities;

namespace Proyecto.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Relación con Productos
        public ICollection<Producto> Productos { get; set; }
    }
}