using System.Collections.Generic;
using j.scr.core.entities;

namespace j.scr.core.usecases
{
    public interface IConsultarAutoresPorGeneroLibro
    {
        List<Autor> Consultar(string genero);
    }
}