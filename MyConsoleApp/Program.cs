using System;
using Microsoft.Extensions.DependencyInjection;
using MyConsoleApp.Models;
using MyConsoleApp.Repositories;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el contenedor de dependencias
            var services = new ServiceCollection();
            services.AddScoped<IFoodRepository, FoodRepository>();

            // Llamamos a Startup para configurar servicios
            var startup = new Startup();
            startup.ConfigureServices(services);

            // Construimos el proveedor
            var serviceProvider = services.BuildServiceProvider();

            // Obtenemos el contexto de base de datos desde DI
            using var context = serviceProvider.GetRequiredService<BloggingContext>();

            // Acá podés hacer algo con el contexto, por ejemplo:
            context.Database.EnsureCreated();

            context.Blogs.Add(new Blog { Url = "https://ejemplo.com" });
            context.SaveChanges();

            foreach (var blog in context.Blogs)
            {
                Console.WriteLine($"Blog: {blog.BlogId} - {blog.Url}");
            }
        }
    }
}