using System.Collections.Generic;
using j.scr.core.entities;

namespace j.scr.core.usecases
{
    public interface IConsultarLibrosPorNombre
    {
        List<Libro> Consultar(string keyword);
    }
}