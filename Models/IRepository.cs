namespace DockerEssentials.Models
{
    public interface IRepository
    {
        IEnumerable<Produto> Produtos { get; }
    }
}