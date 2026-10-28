using System;

namespace GestionProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            IProductoRepository repo = new ProductoRepository();



            Console.WriteLine("\nLISTA COMPLETA DE PRODUCTOS");

            foreach (Producto producto in repo.ObtenerTodos())
            {
                Console.WriteLine(
                    $"ID: {producto.Id} | " +
                    $"Nombre: {producto.Nombre} | " +
                    $"Precio: ${producto.Precio} | " +
                    $"Categoria: {producto.Categoria} | " +
                    $"Activo: {producto.Activo}");
            }

            Console.WriteLine("\nBUSQUEDA DE PRODUCTO POR ID");

            int idBuscado = 3;
            Producto? encontrado = repo.ObtenerPorId(idBuscado);

            if (encontrado != null)
            {
                Console.WriteLine(
                    $"Encontrado: {encontrado.Nombre} - " +
                    $"Precio: ${encontrado.Precio}");
            }
            else
            {
                Console.WriteLine("No se encontro el producto.");
            }

            Console.WriteLine("\nPRODUCTOS DE LA CATEGORIA ALIMENTOS");

            var productosCategoria =
                repo.BuscarPorCategoria("Alimentos");

            foreach (Producto producto in productosCategoria)
            {
                Console.WriteLine(
                    $"{producto.Nombre} - ${producto.Precio}");
            }

            Console.WriteLine("\nPRODUCTO AGREGADO");

            Producto nuevoProducto = new Producto
            {
                Id = 5,
                Nombre = "Fideos",
                Precio = 1800m,
                Categoria = "Alimentos",
                Activo = true
            };

            repo.Agregar(nuevoProducto);

            Console.WriteLine(
                $"Producto agregado: {nuevoProducto.Nombre}");

            Console.WriteLine("\nLISTA ACTUALIZADA");

            foreach (Producto producto in repo.ObtenerTodos())
            {
                Console.WriteLine(
                    $"{producto.Id} - {producto.Nombre} - " +
                    $"${producto.Precio}");
            }


        }
    }
}
