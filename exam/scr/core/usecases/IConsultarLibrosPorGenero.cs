using System.Collections.Generic;
using j.scr.core.entities;

namespace j.scr.core.usecases
{
    public interface IConsultarLibrosPorGenero
    {
        List<Libro> Consultar(string genero);
    }
}