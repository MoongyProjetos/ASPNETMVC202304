// See https://aka.ms/new-console-template for more information
using Exemplo.Common;
using Exemplo.Common.Services;

Console.WriteLine("Hello, World!");

var meuValidador = new Validador();
var meuNif = "123456789";

if (meuValidador.ValidarNIF(meuNif))
{
    Console.WriteLine("NIF Valido");
}


IPagamento meuAdaptador = new PaypalAdapter();
meuAdaptador.ValidarPagamento(10000M);
meuAdaptador.EfetuarPagamento(new DadosPagamento());