using System.Collections.Generic;
using j.scr.core.entities;

namespace j.scr.core.usecases
{
    public interface IConsultarLibrosPorNacionalidadAutor
    {
        List<Libro> Consultar(string nacionalidad);
    }
}