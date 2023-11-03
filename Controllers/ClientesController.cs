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


            return View(clientes);
        }

        public IActionResult Crear()
        {
            return View();
        }

    }
}