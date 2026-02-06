using System;
using System.Collections.Generic;
using System.Linq;
using examen.cose;

namespace examen
{
    public static class DataSource
    {
        public static List<Autor> Autores { get; } = new List<Autor>
        {
            new Autor { Nombre = "Gabriel García Márquez", Pais = "Colombia", AnioNacimiento = 1927 },
            new Autor { Nombre = "George Orwell", Pais = "Reino Unido", AnioNacimiento = 1903 },
            new Autor { Nombre = "J.R.R. Tolkien", Pais = "Reino Unido", AnioNacimiento = 1892 },
            new Autor { Nombre = "Aldous Huxley", Pais = "Reino Unido", AnioNacimiento = 1894 },
            new Autor { Nombre = "Isaac Asimov", Pais = "Rusia", AnioNacimiento = 1920 },
            new Autor { Nombre = "Julio Cortázar", Pais = "Argentina", AnioNacimiento = 1914 }
        };

        public static List<Libro> Libros { get; } = new List<Libro>
        {
            new Libro {
                Nombre = "Cien años de soledad",
                Autores = "Gabriel García Márquez",
                AnioNacimiento = 1967,
                Genero = "Realismo mágico",
                Idioma = "Español",
                Precio = 25.50,
                Pais = "Colombia"
            },
            new Libro {
                Nombre = "El amor en los tiempos del cólera",
                Autores = "Gabriel García Márquez",
                AnioNacimiento = 1985,
                Genero = "Novela",
                Idioma = "Español",
                Precio = 22.00,
                Pais = "Colombia"
            },
            new Libro {
                Nombre = "1984",
                Autores = "George Orwell",
                AnioNacimiento = 1949,
                Genero = "Distopía",
                Idioma = "Inglés",
                Precio = 18.75,
                Pais = "Reino Unido"
            },
            new Libro {
                Nombre = "Un mundo feliz",
                Autores = "Aldous Huxley",
                AnioNacimiento = 1932,
                Genero = "Distopía",
                Idioma = "Inglés",
                Precio = 15.00,
                Pais = "Reino Unido"
            },
            new Libro {
                Nombre = "The Lord of the Rings",
                Autores = "J.R.R. Tolkien",
                AnioNacimiento = 1954,
                Genero = "Fantasía",
                Idioma = "Inglés",
                Precio = 35.00,
                Pais = "Reino Unido"
            },
            new Libro {
                Nombre = "Fundación",
                Autores = "Isaac Asimov",
                AnioNacimiento = 1951,
                Genero = "Ciencia ficción",
                Idioma = "Inglés",
                Precio = 20.00,
                Pais = "Estados Unidos"
            },
            new Libro {
                Nombre = "Rayuela",
                Autores = "Julio Cortázar",
                AnioNacimiento = 1963,
                Genero = "Novela",
                Idioma = "Español",
                Precio = 23.00,
                Pais = "Argentina"
            }
        };
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = DataSource.Libros;

            while (true)
            {
                Console.WriteLine("\nSeleccione una opción de búsqueda:");
                Console.WriteLine("1. Buscar por idioma");
                Console.WriteLine("2. Buscar por género (subgénero)");
                Console.WriteLine("3. Buscar por una palabra en el título");
                Console.WriteLine("4. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el idioma:");
                        string idioma = Console.ReadLine();
                        var porIdioma = libros.Where(l => l.Idioma.Equals(idioma, StringComparison.OrdinalIgnoreCase)).ToList();
                        MostrarResultados(porIdioma, "idioma", idioma);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el género:");
                        string genero = Console.ReadLine();
                        var porGenero = libros.Where(l => l.Genero.Equals(genero, StringComparison.OrdinalIgnoreCase)).ToList();
                        MostrarResultados(porGenero, "género", genero);
                        break;
                    case "3":
                        Console.WriteLine("Ingrese una palabra del título:");
                        string palabra = Console.ReadLine();
                        var porPalabra = libros.Where(l => l.Nombre.Contains(palabra, StringComparison.OrdinalIgnoreCase)).ToList();
                        MostrarResultados(porPalabra, "palabra en el título", palabra);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void MostrarResultados(List<Libro> libros, string criterio, string valor)
        {
            if (libros.Any())
            {
                Console.WriteLine($"\nLibros encontrados por {criterio} '{valor}':");
                foreach (var libro in libros)
                {
                    Console.WriteLine($"- {libro.Nombre} por {libro.Autores} ({libro.AnioNacimiento}), Género: {libro.Genero}, Idioma: {libro.Idioma}, Precio: ${libro.Precio}");
                }
            }
            else
            {
                Console.WriteLine($"\nNo se encontraron libros por {criterio} '{valor}'. Creando uno nuevo como ejemplo:");
                var nuevoLibro = new Libro
                {
                    Nombre = $"El misterio de {valor}",
                    Autores = "Autor Desconocido",
                    AnioNacimiento = DateTime.Now.Year,
                    Genero = criterio == "género" ? valor : "Aventura",
                    Idioma = criterio == "idioma" ? valor : "Desconocido",
                    Precio = 20.00,
                    Pais = "Mundo"
                };
                Console.WriteLine($"- {nuevoLibro.Nombre} por {nuevoLibro.Autores} ({nuevoLibro.AnioNacimiento}), Género: {nuevoLibro.Genero}, Idioma: {nuevoLibro.Idioma}, Precio: ${nuevoLibro.Precio}");
            }
        }
    }
}
