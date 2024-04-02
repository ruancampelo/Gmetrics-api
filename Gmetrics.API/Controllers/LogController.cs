using Application.ViewModel;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Gmetrics.API.Controllers
{
    [ApiController]
    public class LogController : Controller
    {
        private readonly ILogRepository _logRepository;

        public LogController(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }


        [HttpGet]
        [Route("obter-logs")]
        public async Task<IActionResult> ObterLogsAsync()
        {
            var products = await _logRepository.ObterTodosLogs();
            return Ok(products);
        }

        [HttpPost]
        [Route("criar-log")]
        public async Task<IActionResult> CriarLogAsync([FromBody] LogRequest log)
        {
            var entidade = new Log
            {
                Tag = log.Tag,
                Mensagem = log.Mensagem,
                Criacao = log.Criacao,
                TipoLog = (Domain.TipoLog)log.TipoLog,
                IdProduto = log.IdProduto,
            };

            await _logRepository.AdicionarLog(entidade);
            return Ok();
        }


        [HttpGet]
        [Route("obter-logs-tempo-tela/{idProduto}")]
        public async Task<IActionResult> ObterLogsTempoTela(Guid idProduto)
        {
            var products = await _logRepository.ObterLogsPorTempoDeTela(idProduto);
            return Ok(products);
        }

        [HttpGet]
        [Route("obter-tags-por-produto/{idProduto}")]
        public async Task<IActionResult> ObterTags(Guid idProduto)
        {
            var products = await _logRepository.ObterTagsPorIdProduto(idProduto);
            return Ok(products);
        }
    }
}
