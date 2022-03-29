namespace DockerEssentials.Models
{
    public class Produto
    {
        public Produto(string nome, string categoria, decimal preco)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }

        public int? ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
    }
}