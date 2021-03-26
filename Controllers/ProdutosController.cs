using Microsoft.AspNetCore.Mvc;
using Atividade_4.Models;

namespace Atividade_4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterProdutos()
        {
            return Ok(new ProdutosVendasContext().BuscaProdutosNoBD());
        }

        [HttpPost]
        public IActionResult inserirProduto(Produto p)
        {
            if(!ModelState.IsValid)return BadRequest(ModelState);
            new ProdutosVendasContext().InsereProdutoNoBD(p);
            return Ok(p);
        }
    }
}
