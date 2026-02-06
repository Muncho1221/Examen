namespace j.scr.core.entities
{
    public class Libro
    {
        public required string Nombre { get; set; }
        public required string Genero { get; set; }
        public required Autor Autor { get; set; }
    }
}