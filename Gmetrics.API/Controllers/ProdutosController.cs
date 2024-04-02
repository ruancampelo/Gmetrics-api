using Microsoft.AspNetCore.Mvc;

namespace Gmetrics.API.Controllers
{
    public class ProdutosController : Controller
    {
        [HttpGet]
        [Route("obter-produtos")]
        public async Task<IActionResult> ObterLogsAsync()
        {
            List<object> objetos = new List<object>();

            for (int i = 0; i < 5; i++)
            {
                var objeto = new
                {
                    Id = Guid.NewGuid(),
                    Nome = "SG " + (i + 1)
                };

                objetos.Add(objeto);
            }
            return Ok(objetos);
        }
    }
}
