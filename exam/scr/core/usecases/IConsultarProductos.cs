using System.Collections.Generic;
using j.scr.core.entities;

namespace j.scr.core.usecases
{
    public interface IConsultarProductos
    {
        List<Articulo> Ejecutar();
    }
}