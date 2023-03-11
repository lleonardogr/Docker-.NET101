using DockerTest.Models;
using DockerTest.Repository.Context;

namespace DockerTest.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private DockerTestDbContext _context;

        public ProdutoRepository(DockerTestDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> ListarProdutos() => _context.Produtos;

        public Produto ObterProdutoPorId(int id) => _context.Produtos.FirstOrDefault(p => p.Id == id);

        public void AdicionarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void AtualizarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public void RemoverProduto(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
    }
}
