// See https://aka.ms/new-console-template for more information
using Exemplo.Common;

Console.WriteLine("Hello, World!");

var meuValidador = new Validador();
var meuNif = "123456789";

if (meuValidador.ValidarNIF(meuNif))
{
    Console.WriteLine("NIF Valido");
}