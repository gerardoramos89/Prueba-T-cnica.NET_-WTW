using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Dapper.Data;
using MVC_Dapper.Models;


namespace MVC_Dapper.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClientes _iclientes;
        private readonly IFactura _ifactura;
        private readonly IProducto _iproducto;
        decimal totalfactura = 0;
        decimal subtotal = 0;


        public ClientesController(IClientes iclientes, IProducto iproductos)
        {
            _iclientes = iclientes;
            _iproducto = iproductos;
        }

        public IActionResult Index()
        {
            var clientes =   _iclientes.ObtenerClientes();
            var productos =   _iproducto.ObtenerProductos();
            ViewBag.productos = productos;
            ViewBag.subtotal = subtotal;
            ViewBag.totalfactura = totalfactura;
            ViewBag.impuesto = (19 * totalfactura) / 100;

            return View(clientes);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MiMetodo(int selectedValue)
        {
            subtotal = selectedValue * subtotal;

            return Json(new { success = true, message = "Operación exitosa" });
        }
    }
}