using System.Data;
using Dapper;
using MVC_ControlFacturas.Models;
using MVC_Dapper.Models;

namespace MVC_Dapper.Data
{
    public class FacturaImple : IFactura
    {
        private readonly Conexion _conexion;

        public FacturaImple(Conexion conexion)
        {
            _conexion = conexion;
        }

        public IEnumerable<Factura> ObtenerFactura()
        {
            using (var conexion = _conexion.ObtenerConexion())
            {
                return conexion.Query<Factura>("SPIObtenerFacturas", commandType: CommandType.StoredProcedure).ToList();
            }
        }

    }
}