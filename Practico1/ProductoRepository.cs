using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionProductos
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly List<Producto> productos;

        public ProductoRepository()
        {
            productos = new List<Producto>
            {
                new Producto
                {
                    Id = 1,
                    Nombre = "Arroz",
                    Precio = 1500m,
                    Categoria = "Alimentos",
                    Activo = true
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "Leche",
                    Precio = 1200m,
                    Categoria = "Alimentos",
                    Activo = true
                },
                new Producto
                {
                    Id = 3,
                    Nombre = "Shampoo",
                    Precio = 2500m,
                    Categoria = "Higiene",
                    Activo = true
                },
                new Producto
                {
                    Id = 4,
                    Nombre = "Jabon",
                    Precio = 900m,
                    Categoria = "Higiene",
                    Activo = false
                }
            };
        }

        public void Agregar(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> ObtenerTodos()
        {
            return productos.ToList();
        }

        public Producto? ObtenerPorId(int id)
        {
            return productos.FirstOrDefault(p => p.Id == id);
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            return productos
                .Where(p => p.Categoria.Equals(
                    categoria,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
