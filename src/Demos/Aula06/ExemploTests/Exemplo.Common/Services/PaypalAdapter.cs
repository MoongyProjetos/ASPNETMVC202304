using Exemplo.Common.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Common.Services
{
    public class PaypalAdapter : IPagamento
    {
        public bool ValidarPagamento(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Deu problema no valor");
            }

            if (valor == 21)
            {
                throw new NumberNotValidException();
            }

            var exemplo = valor / valor;

            return valor > 0;
        }

        public ResultadoOperacao EfetuarPagamento(DadosPagamento pagamento)
        {
            var resultado = new ResultadoOperacao(pagamento.Valor);

            return resultado;
        }
    }
}
