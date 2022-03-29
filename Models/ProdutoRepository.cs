namespace DockerEssentials.Models
{
    public class ProdutoRepository : IRepository
    {
        private AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos 
        {
            get 
            {
                var produtos = _context.Produtos ?? new List<Produto>() as IEnumerable<Produto>;
                return produtos;
            }
        }
    }
}