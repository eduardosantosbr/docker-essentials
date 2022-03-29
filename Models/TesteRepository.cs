namespace DockerEssentials.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[]
        {
            // new Produto{ ProdutoId = 10, Nome = "Caneta", Categoria = "Material" },
            // new Produto{ ProdutoId = 20, Nome = "Borracha", Categoria = "Material" },
            // new Produto{ ProdutoId = 30, Nome = "Estojo", Categoria = "Material" },
        };

        public IEnumerable<Produto> Produtos { get => produtos; }
    }
}