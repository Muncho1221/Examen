using System.Collections.Generic;
using System.Linq;
using j.scr.core.entities;
using j.scr.core.usecases;

namespace j.scr.application
{
    public class ConsultarAutoresPorGeneroLibroUseCase : IConsultarAutoresPorGeneroLibro
    {
        private readonly List<Libro> _libros;

        public ConsultarAutoresPorGeneroLibroUseCase()
        {
            // Placeholder data
            var autor1 = new Autor { Nombre = "Jane Austen", Nacionalidad = "Británica" };
            var autor2 = new Autor { Nombre = "Gabriel Garcia Marquez", Nacionalidad = "Colombiana" };
            var autor3 = new Autor { Nombre = "Nicholas Sparks", Nacionalidad = "Estadounidense" };
            var autor4 = new Autor { Nombre = "Isaac Asimov", Nacionalidad = "Rusa" };


            _libros = new List<Libro>
            {
                new Libro { Nombre = "Orgullo y Prejuicio", Genero = "Romance", Autor = autor1 },
                new Libro { Nombre = "El amor en los tiempos del cólera", Genero = "Romance", Autor = autor2 },
                new Libro { Nombre = "Diario de una pasión", Genero = "Romance", Autor = autor3 },
                new Libro { Nombre = "Yo, Robot", Genero = "Ci-fi", Autor = autor4 },
            };
        }

        public List<Autor> Consultar(string genero)
        {
            return _libros.Where(l => l.Genero.Equals(genero, System.StringComparison.OrdinalIgnoreCase))
                          .Select(l => l.Autor)
                          .Distinct()
                          .ToList();
        }
    }
}