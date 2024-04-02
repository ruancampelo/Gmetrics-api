namespace Application.ViewModel
{
    public class LogRequest
    {
        public string Tag { get; set; }
        public int TipoLog { get; set; }
        public string Mensagem { get; set; }
        public DateTime Criacao { get; set; }
        public Guid IdProduto { get; set; }
    }
}
