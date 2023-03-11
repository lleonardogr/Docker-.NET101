using DockerTest.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DockerTest.Controllers
{
    public class ProdutoController : Controller
    {
        public IProdutoRepository _produtoRepository;
        private string message;
        public ProdutoController(IProdutoRepository produtoRepository, IConfiguration config)
        {
            message = $"Docker - ({config["HOSTNAME"]})";
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Message = message;
            return View(_produtoRepository.ListarProdutos());
        }
    }
}
