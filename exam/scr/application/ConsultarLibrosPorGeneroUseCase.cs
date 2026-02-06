using System.Collections.Generic;
using System.Linq;
using j.scr.core.entities;
using j.scr.core.usecases;

namespace j.scr.application
{
    public class ConsultarLibrosPorGeneroUseCase : IConsultarLibrosPorGenero
    {
        private readonly List<Libro> _libros;

        public ConsultarLibrosPorGeneroUseCase()
        {
            // Placeholder data
            var autor1 = new Autor { Nombre = "George Orwell", Nacionalidad = "Británica" };
            var autor2 = new Autor { Nombre = "Isaac Asimov", Nacionalidad = "Rusa" };
            var autor3 = new Autor { Nombre = "Jane Austen", Nacionalidad = "Británica" };
            var autor4 = new Autor { Nombre = "Gabriel Garcia Marquez", Nacionalidad = "Colombiana" };

            _libros = new List<Libro>
            {
                new Libro { Nombre = "1984", Genero = "Ci-fi", Autor = autor1 },
                new Libro { Nombre = "Yo, Robot", Genero = "Ci-fi", Autor = autor2 },
                new Libro { Nombre = "Orgullo y Prejuicio", Genero = "Romance", Autor = autor3 },
                new Libro { Nombre = "Cien años de soledad", Genero = "Realismo Mágico", Autor = autor4 },
            };
        }

        public List<Libro> Consultar(string genero)
        {
            return _libros.Where(l => l.Genero.Equals(genero, System.StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}