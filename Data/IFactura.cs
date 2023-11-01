using MVC_ControlFacturas.Models;

namespace MVC_Dapper.Data
{
    public interface IFactura
    {
        IEnumerable<Factura> ObtenerFactura();
    }
}