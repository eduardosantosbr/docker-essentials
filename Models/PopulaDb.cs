using Microsoft.EntityFrameworkCore;

namespace DockerEssentials.Models
{
    public static class PopulaDb
    {
        public static void IncluiDadosDb(IApplicationBuilder app)
        {
            IncluiDadosDb(app.ApplicationServices.GetRequiredService<AppDbContext>());
        }

        public static void IncluiDadosDb(AppDbContext context)
        {
            System.Console.WriteLine("Aplicando Migrations...");
            context.Database.Migrate();

            if (context.Produtos != null && !context.Produtos.Any())
            {
                System.Console.WriteLine("Criando dados...");
                context.AddRange(
                    new Produto("Luvas de goleiro", "Futebol", 25),
                    new Produto("Bola de basquete", "Basquete", 25),
                    new Produto("Bola de futebol", "Futebol", 25),
                    new Produto("Meias grandes", "Futebol", 25),
                    new Produto("Cesta para quadra", "Basquete", 25)
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Dados já existem...");
            }
        }
    }
}