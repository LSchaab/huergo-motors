using System;

namespace DTO
{
    public class VentasAccesorios
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public int IdVehiculo { get; set; }
        public string ModeloVehiculo { get; set; }
        public int IdAccesorio { get; set; }
        public string NombreAccesorio { get; set; }
        public decimal Precio { get; set; }
    }
}
