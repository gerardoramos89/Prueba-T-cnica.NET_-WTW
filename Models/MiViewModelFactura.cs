using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Dapper.Data;
namespace MVC_ControlFacturas.Models
{
    public class MiViewModelFactura
    {
        public IEnumerable<SelectListItem> ListaItems { get; set; }
        public int ItemSeleccionadoId { get; set; }
    }
}
