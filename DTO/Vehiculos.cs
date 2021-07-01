namespace DTO
{
    public class Vehiculos : DTOBase
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
    }
}
