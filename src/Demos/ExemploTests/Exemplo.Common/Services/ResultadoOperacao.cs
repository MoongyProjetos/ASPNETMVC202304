namespace Exemplo.Common.Services
{
    public class ResultadoOperacao
    {
        public bool TeveSucesso { get; set; }
        public ResultadoOperacao(decimal valor)
        {
            TeveSucesso = valor > 0;
        }
    }
}