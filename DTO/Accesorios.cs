namespace DTO
{
    public class Accesorios : DTOBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public int IdVehiculo { get; set; }
        public string ModeloVehiculo { get; set; }
        public string NombreTipo => Nombre + " " + Tipo;
    }
}
