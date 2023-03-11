using DockerTest.Models;

namespace DockerTest.Repository
{
    public interface IProdutoRepository
    {
        public IEnumerable<Produto> ListarProdutos();

        public Produto ObterProdutoPorId(int id);

        public void AdicionarProduto(Produto produto);

        public void AtualizarProduto(Produto produto);

        public void RemoverProduto(int id);
    }
}
