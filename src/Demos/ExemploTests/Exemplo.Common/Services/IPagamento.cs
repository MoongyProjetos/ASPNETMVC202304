namespace Exemplo.Common.Services
{
    public interface IPagamento
    {
        bool ValidarPagamento(decimal valor);
        ResultadoOperacao EfetuarPagamento(DadosPagamento pagamento);
    }
}
