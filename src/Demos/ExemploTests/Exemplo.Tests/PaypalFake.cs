using Exemplo.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Tests
{
    public class PaypalFake : IPagamento
    {
        public ResultadoOperacao EfetuarPagamento(DadosPagamento pagamento)
        {
            return new ResultadoOperacao(pagamento.Valor);
        }

        public bool ValidarPagamento(decimal valor)
        {
            return true;
        }
    }
}
