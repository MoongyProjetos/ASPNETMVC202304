namespace Exemplo.Common;
public class Validador
{
    public bool ValidarNIF(string valor)
    {
        if (valor.Length != 9)
        {
            return false;
        }

        if (valor.Distinct().Count() == 1)
        {
            return false;
        }

        var valoresAceitosNoInicio = new List<char> { '1', '2', '3', '4', '5' };
        if (!valoresAceitosNoInicio.Contains(valor[0]))
        {
            return false;
        }


        return true;
    }
}
