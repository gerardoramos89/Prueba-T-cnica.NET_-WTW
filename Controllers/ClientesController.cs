using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_ControlFacturas.Models;
using MVC_Dapper.Data;
using MVC_Dapper.Models;


namespace MVC_Dapper.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClientes _iclientes;

        public ClientesController(IClientes iclientes)
        {
            _iclientes = iclientes;
        }

        public IActionResult Index()
        {
            var clientes = _iclientes.ObtenerClientes();




            return View(clientes);

        }

        public IActionResult Crear()
        {
            return View();
        }

    }
}