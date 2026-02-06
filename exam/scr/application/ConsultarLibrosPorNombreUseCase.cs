using System.Collections.Generic;
using System.Linq;
using j.scr.core.entities;
using j.scr.core.usecases;

namespace j.scr.application
{
    public class ConsultarLibrosPorNombreUseCase : IConsultarLibrosPorNombre
    {
        private readonly List<Libro> _libros;

        public ConsultarLibrosPorNombreUseCase()
        {
            // Placeholder data
            var autor1 = new Autor { Nombre = "A. Baldor", Nacionalidad = "Cubana" };
            var autor2 = new Autor { Nombre = "Serge Lang", Nacionalidad = "Francesa" };
            var autor3 = new Autor { Nombre = "Isaac Asimov", Nacionalidad = "Rusa" };

            _libros = new List<Libro>
            {
                new Libro { Nombre = "Álgebra de Baldor", Genero = "Educación", Autor = autor1 },
                new Libro { Nombre = "Álgebra Lineal", Genero = "Educación", Autor = autor2 },
                new Libro { Nombre = "Yo, Robot", Genero = "Ci-fi", Autor = autor3 },
            };
        }

        public List<Libro> Consultar(string keyword)
        {
            return _libros.Where(l => l.Nombre.ToLower().Contains(keyword.ToLower())).ToList();
        }
    }
}