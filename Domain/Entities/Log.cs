using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{

    [Table("TB_METRICS")]
    public class Log
    {
        public long Id { get; set; }
        public string Tag { get; set; }
        public TipoLog TipoLog { get; set; }
        public string Mensagem { get; set; }
        public DateTime Criacao { get; set; }
        public Guid IdProduto { get; set; }
    }
}
