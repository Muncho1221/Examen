using System;
using System.Collections.Generic;
using j.scr.application;
using j.scr.core.entities;
using j.scr.core.usecases;

namespace j
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // --- Código anterior de Artículos ---
            Console.WriteLine("Generando y mostrando 25 artículos aleatorios:");
            Console.WriteLine("---------------------------------------------");
            IConsultarProductos consultarProductos = new ConsultarProductosUseCase();
            List<Articulo> articulos = consultarProductos.Ejecutar();
            foreach (var articulo in articulos)
            {
                Console.WriteLine($"Nombre: {articulo.Nombre}, Precio: {articulo.Precio:C}, SKU: {articulo.SKU}, Stock: {articulo.Stock}, Marca: {articulo.Marca}");
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\nAdicionando 5 nuevos artículos:");
            Console.WriteLine("---------------------------------------------");
            ICrearProductos crearProductos = new CrearProductosUseCase();
            List<Articulo> nuevosArticulos = new List<Articulo>
            {
                new Articulo { Nombre = "Monitor Curvo", Precio = 499.99m, SKU = "MONC01", Stock = 15, Marca = "Samsung" },
                new Articulo { Nombre = "Tarjeta Gráfica RTX 4080", Precio = 1199.99m, SKU = "GPU4080", Stock = 5, Marca = "Nvidia" },
                new Articulo { Nombre = "Webcam HD", Precio = 69.99m, SKU = "WEBC02", Stock = 30, Marca = "Logitech" },
                new Articulo { Nombre = "Silla Gamer Ergonómica", Precio = 249.00m, SKU = "GAMEC01", Stock = 10, Marca = "DXRacer" },
                new Articulo { Nombre = "Adaptador USB-C a HDMI", Precio = 19.50m, SKU = "USBC2H", Stock = 100, Marca = "Anker" }
            };
            foreach (var nuevoArticulo in nuevosArticulos)
            {
                crearProductos.Crear(nuevoArticulo);
            }
            Console.WriteLine("\nTodos los nuevos artículos han sido procesados.");
            */

            Console.WriteLine("--- DEMOSTRACIÓN DE CASOS DE USO DE LIBROS ---");

            // 1. Consultar libros de género 'Ci-fi'
            Console.WriteLine("\n1. Libros de género 'Ci-fi':");
            IConsultarLibrosPorGenero consultarPorGenero = new ConsultarLibrosPorGeneroUseCase();
            List<Libro> librosCiFi = consultarPorGenero.Consultar("Ci-fi");
            foreach (var libro in librosCiFi)
            {
                Console.WriteLine($"  - {libro.Nombre} por {libro.Autor.Nombre}");
            }

            // 2. Consultar libros cuyo nombre contenga 'álgebra'
            Console.WriteLine("\n2. Libros que contienen 'álgebra' en el nombre:");
            IConsultarLibrosPorNombre consultarPorNombre = new ConsultarLibrosPorNombreUseCase();
            List<Libro> librosAlgebra = consultarPorNombre.Consultar("álgebra");
            foreach (var libro in librosAlgebra)
            {
                Console.WriteLine($"  - {libro.Nombre} por {libro.Autor.Nombre}");
            }

            // 3. Consultar libros escritos por autores franceses
            Console.WriteLine("\n3. Libros de autores franceses:");
            IConsultarLibrosPorNacionalidadAutor consultarPorNacionalidad = new ConsultarLibrosPorNacionalidadAutorUseCase();
            List<Libro> librosFranceses = consultarPorNacionalidad.Consultar("Francesa");
            foreach (var libro in librosFranceses)
            {
                Console.WriteLine($"  - {libro.Nombre} por {libro.Autor.Nombre}");
            }

            // 4. Consultar autores que hayan escrito libros de 'Romance'
            Console.WriteLine("\n4. Autores de libros de 'Romance':");
            IConsultarAutoresPorGeneroLibro consultarAutores = new ConsultarAutoresPorGeneroLibroUseCase();
            List<Autor> autoresRomance = consultarAutores.Consultar("Romance");
            foreach (var autor in autoresRomance)
            {
                Console.WriteLine($"  - {autor.Nombre} ({autor.Nacionalidad})");
            }

            Console.WriteLine("\n--- Fin de la demostración ---");
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}