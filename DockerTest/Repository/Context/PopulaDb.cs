using DockerTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerTest.Repository.Context
{
    public static class PopulaDb
    {
        public static void IncluirDadosDb(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetRequiredService<DockerTestDbContext>())
                {
                    //IncluirDadosDb(context);
                }
            }
        }

        private static void IncluirDadosDb(DockerTestDbContext context)
        {
            Console.WriteLine("Aplicando Migrations...");
            context.Database.Migrate();

            if (!context.Produtos.Any())
            {
                Console.WriteLine("Criando Dados...");
                context.Produtos.AddRange(
                    new Produto() { Nome = "Caneta", Categoria = "Material Escolar", Preco = (decimal)3.5 },
                    new Produto() { Nome = "Borracha", Categoria = "Material Escolar", Preco = (decimal)4.5 },
                    new Produto() { Nome = "Estojo", Categoria = "Material Escolar", Preco = (decimal)10.5 }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Dados já existe");
            }
        }
    }
}
