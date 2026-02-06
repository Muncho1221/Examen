using System;
using System.Collections.Generic;
using System.Linq;
using j.scr.core.entities;
using j.scr.core.usecases;

namespace j.scr.application
{
    public class ConsultarProductosUseCase : IConsultarProductos
    {
        private readonly Random _random = new Random();

        public List<Articulo> Ejecutar()
        {
            var articulos = new List<Articulo>();
            string[] productNames = { "Laptop", "Mouse", "Teclado", "Monitor", "Webcam", "Auriculares", "Impresora", "Router", "Disco Duro", "SSD" };
            string[] brands = { "Dell", "HP", "Logitech", "Samsung", "Sony", "Apple", "Acer", "Asus", "Razer", "Corsair" };

            for (int i = 0; i < 25; i++)
            {
                string nombre = productNames[_random.Next(productNames.Length)];
                decimal precio = (decimal)Math.Round(_random.NextDouble() * (1500.00 - 10.00) + 10.00, 2); // Price between 10.00 and 1500.00
                string sku = $"SKU{_random.Next(10000, 99999)}";
                int stock = _random.Next(0, 200); // Stock between 0 and 199
                string marca = brands[_random.Next(brands.Length)];

                articulos.Add(new Articulo
                {
                    Nombre = nombre,
                    Precio = precio,
                    SKU = sku,
                    Stock = stock,
                    Marca = marca
                });
            }

            return articulos;
        }
    }
}