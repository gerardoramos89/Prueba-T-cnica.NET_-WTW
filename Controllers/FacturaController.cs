using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

            var facturas = _ifactura.ObtenerFactura();

            return View(facturas);

        }

        public IActionResult Crear()
        {
            return View();
        }

 
    }
}