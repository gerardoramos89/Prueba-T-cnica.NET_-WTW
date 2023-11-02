namespace MVC_Dapper.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int idCliente { get; set; }
        public DateTime fechaemisionfactura { get; set; }
        public int numerofactura { get; set; }

    }
}
