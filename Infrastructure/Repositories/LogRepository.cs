using Domain.Entities;
using Domain.Enum;
using Domain.Repositories;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly GmetricsContext _context;

        public LogRepository(GmetricsContext context)
        {
            _context = context;
        }

        public async Task AdicionarLog(Log log)
        {
             await _context.AddAsync(log);
             await _context.SaveChangesAsync(); 
        }

        public async Task<IEnumerable<Log>> ObterTodosLogs()
        {
            return await _context.Set<Log>().ToListAsync();
        }
        public async Task<IEnumerable<Log>> ObterLogsPorTempoDeTela(Guid idProduto)
        {
            return await _context.Set<Log>()
                .AsNoTracking()
                .Where(x  => x.TipoLog == TipoLog.TempoResosta && x.IdProduto == idProduto)
                .ToListAsync();
        }

        public IEnumerable<string> ObterTagsPorIdProduto(Guid idProduto)
        {
            var resultado =  _context.Set<Log>()
                                                .AsNoTracking()
                                                .Where(x => x.IdProduto == idProduto)
                                                .Select(x => x.Tag)
                                                .ToList();
            return resultado;
        }
    }
}
