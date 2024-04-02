using System.ComponentModel;

namespace Domain.Enum
{
    public enum TipoLog
    {
        [Description("Tempo de Tela")]
        Erro = 1,

        [Description("Taxa de Error")]
        TaxaErro = 2,

        [Description("Tempo de Resposta")]
        TempoResosta = 3,

        [Description("Metrica Livre")]
        Livre = 4,
    }
}
