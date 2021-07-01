using System;

namespace DTO
{
    public class Ventas : DTOBase
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdVehiculo { get; set; }
        public string ModeloVehiculo { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string Observaciones { get; set; }
        public decimal Total { get; set; }
    }
}
