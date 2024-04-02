using Domain.Entities;

namespace Domain.Repositories
{
    public interface ILogRepository
    {
        Task AdicionarLog(Log log);
        Task<IEnumerable<Log>> ObterTodosLogs();
        Task<IEnumerable<Log>> ObterLogsPorTempoDeTela(Guid idProduto);
        IEnumerable<string> ObterTagsPorIdProduto(Guid idProduto);
    }
}
