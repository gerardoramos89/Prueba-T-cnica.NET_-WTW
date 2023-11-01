using Microsoft.AspNetCore.Mvc;
using MVC_ControlFacturas.Models;
using MVC_Dapper.Data;
using MVC_Dapper.Models;

namespace MVC_Dapper.Controllers
{
    public class FacturaController : Controller
    {
        private readonly IFactura _ifactura;

        public FacturaController(IFactura ifactura)
        {
            _ifactura = ifactura;
        }

        public IActionResult Index()
        {
            var producto = _ifactura.ObtenerFactura();
            return View(producto);
        }

        public IActionResult Crear()
        {
            return View();
        }

    }
}