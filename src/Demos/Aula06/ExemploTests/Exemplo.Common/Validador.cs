namespace Exemplo.Common;
public class Validador
{
    public bool ValidarNIF(string valor)
    {
        var valoresAceitosNoInicio = new List<char> { '1', '2', '3', '4', '5' };
        if (!valoresAceitosNoInicio.Contains(valor[0]) || valor.Length != 9 || valor.Distinct().Count() == 1)
        {
            return false;
        }

        return true;
    }
}
