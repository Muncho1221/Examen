using System;
using j.scr.core.entities;
using j.scr.core.usecases;

namespace j.scr.application
{
    public class CrearProductosUseCase : ICrearProductos
    {
        public void Crear(Articulo nuevoArticulo)
        {
            // In a real application, this would interact with a data repository
            // to persist the new article (e.g., save to a database).
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Creando nuevo artículo:");
            Console.WriteLine($"  Nombre: {nuevoArticulo.Nombre}");
            Console.WriteLine($"  Precio: {nuevoArticulo.Precio:C}");
            Console.WriteLine($"  SKU: {nuevoArticulo.SKU}");
            Console.WriteLine($"  Stock: {nuevoArticulo.Stock}");
            Console.WriteLine($"  Marca: {nuevoArticulo.Marca}");
            Console.WriteLine("Artículo creado exitosamente (simulado).");
            Console.WriteLine("---------------------------------------------");
        }
    }
}