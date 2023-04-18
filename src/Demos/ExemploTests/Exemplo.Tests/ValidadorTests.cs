using Exemplo.Common;

namespace Exemplo.Tests;

[TestClass]
public class ValidadorTests
{
    [TestMethod]
    public void DadoQueUmNifFoiInformado_DeveValidarSePossuiNoveDigitos()
    {
        //Arrange - Preparo
        var nifInformado = "121111111";

        //Act - Chamar método
        var meuValidador = new Validador();
        var resultadoObtido = meuValidador.ValidarNIF(nifInformado);

        //Assert - Verificacao
        Assert.IsTrue(resultadoObtido);
    }


    [TestMethod]
    public void DadoQueUmNifFoiInformado_DeveValidarSeTodosOsDigitosNaoSaoIguais()
    {
        //Arrange - Preparo
        var nifInformado = "111111111";

        //Act - Chamar método
        var meuValidador = new Validador();
        var resultadoObtido = meuValidador.ValidarNIF(nifInformado);

        //Assert - Verificacao
        Assert.IsFalse(resultadoObtido);
    }


    [DataTestMethod]
    [DataRow("187654321")]
    [DataRow("287654321")]
    [DataRow("387654321")]
    [DataRow("487654321")]
    [DataRow("587654321")]
    public void DadoQueUmNifFoiInformado_DeveValidarSeInicializarComValoresValidos(string nifInformado)
    {
        //Arrange - Preparo
        //var nifInformado = "121111111";

        //Act - Chamar método
        var meuValidador = new Validador();
        var resultadoObtido = meuValidador.ValidarNIF(nifInformado);

        //Assert - Verificacao
        Assert.IsTrue(resultadoObtido);
    }

    [DataTestMethod]
    [DataRow("987654321")]
    [DataRow("887654321")]
    [DataRow("787654321")]
    [DataRow("687654321")]
    public void DadoQueUmNifFoiInformado_DeveInvalidarSeNaoInicializarComValoresValidos(string nifInformado)
    {
        //Arrange - Preparo
        //var nifInformado = "911111111";

        //Act - Chamar método
        var meuValidador = new Validador();
        var resultadoObtido = meuValidador.ValidarNIF(nifInformado);

        //Assert - Verificacao
        Assert.IsFalse(resultadoObtido);
    }





    [DataTestMethod]
    [DataRow("187654321", true)]
    [DataRow("287654321", true)]
    [DataRow("387654321", true)]
    [DataRow("487654321", true)]
    [DataRow("587654321", true)]
    [DataRow("987654321", false)]
    [DataRow("887654321", false)]
    [DataRow("787654321", false)]
    [DataRow("687654321", false)]
    public void DadoQueUmNifFoiInformado_DeveValidarConformeParametros(string nifInformado, bool resultadoEsperado)
    {
        //Arrange - Preparo
        //var nifInformado = "121111111";

        //Act - Chamar método
        var meuValidador = new Validador();
        var resultadoObtido = meuValidador.ValidarNIF(nifInformado);

        //Assert - Verificacao
        Assert.AreEqual(resultadoEsperado, resultadoObtido);
    }

}