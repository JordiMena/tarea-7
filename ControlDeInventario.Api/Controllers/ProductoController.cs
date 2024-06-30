using Microsoft.AspNetCore.Mvc;
using ControlDelInventario.Domain.Entities;
using ControlDelInventario.Domain.Interfaces;

namespace ControlDelInventario.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var productos = _productoRepository.GetAll();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var producto = _productoRepository.GetById(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            _productoRepository.Add(producto);
            return CreatedAtAction(nameof(Get), new { id = producto.Id }, producto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }
            _productoRepository.Update(producto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producto = _productoRepository.GetById(id);
            if (producto == null)
            {
                return NotFound();
            }
            _productoRepository.Delete(id);
            return NoContent();
        }
    }
}
