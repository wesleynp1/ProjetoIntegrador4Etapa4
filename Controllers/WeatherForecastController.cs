using Microsoft.AspNetCore.Mvc;

namespace Atividade_4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterProdutos()
        {
            return Ok("resultado bom");
        }
    }
}
