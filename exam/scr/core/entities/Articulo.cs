namespace j.scr.core.entities
{
    public class Articulo
    {
        public required string Nombre { get; set; }
        public decimal Precio { get; set; }
        public required string SKU { get; set; }
        public int Stock { get; set; }
        public required string Marca { get; set; }
    }
}