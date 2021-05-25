using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC3.Models;

namespace PC3.Controllers
{
    public class BuscoController : Controller
    {
        private readonly BuscarContext _context;
        public BuscoController(BuscarContext context) {
            _context = context;
        }
        public IActionResult Categoria() {
            var categorias = _context.Categorias.Include(x => x.Productos).OrderBy(r => r.Nombre).ToList();
            return View(categorias);
        }

        public IActionResult Productos() {
            var productos = _context.Productos.Include(x => x.Categoria).OrderBy(r => r.Nombre).ToList();
            return View(productos);
        }


        public IActionResult NuevoProducto()
        {
            return View();
        }
         [HttpPost]
        public IActionResult NuevoProducto(Producto r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevoProductoConfirmacion");
            }
            return View(r);
        }
        public IActionResult NuevoProductoConfirmacion()
        {
            return View();
        }

        public IActionResult BorrarProducto(int id) {
            var producto = _context.Productos.Find(id);
            _context.Remove(producto);
            _context.SaveChanges();

            return RedirectToAction("Productos");
        }
    }

    
}