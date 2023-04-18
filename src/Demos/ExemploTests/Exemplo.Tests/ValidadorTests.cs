using Exemplo.Common;

namespace Exemplo.Tests;

[TestClass]
public class ValidadorTests
{
    Validador meuValidador;

    [TestMethod]
    [TestCategory("Testes de dados")]
    public void DadoQueUmNifFoiInformado_DeveValidarSePossuiNoveDigitos()
    {
        //Arrange - Preparo
        var nifInformado = "121111111";

        //Act - Chamar método
        //var meuValidador = new Validador();
        var resultadoObtido = meuValidador.ValidarNIF(nifInformado);

        //Assert - Verificacao
        Assert.IsTrue(resultadoObtido);
    }


    [TestMethod, TestCategory("Testes de dados")]
    public void DadoQueUmNifFoiInformado_DeveValidarSeTodosOsDigitosNaoSaoIguais()
    {
        //Arrange - Preparo
        var nifInformado = "111111111";

        //Act - Chamar método
        //var meuValidador = new Validador();
        var resultadoObtido = meuValidador.ValidarNIF(nifInformado);

        //Assert - Verificacao
        Assert.IsFalse(resultadoObtido);
    }


    [DataTestMethod]
    [TestCategory("Teste Aleatorio")]
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
        //var meuValidador = new Validador();
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
        //Act - Chamar método
        //var meuValidador = new Validador();
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
        //Act - Chamar método
        //var meuValidador = new Validador();
        var resultadoObtido = meuValidador.ValidarNIF(nifInformado);

        //Assert - Verificacao
        Assert.AreEqual(resultadoEsperado, resultadoObtido);
    }

#if !DEBUG
    [Ignore]
#endif
    [TestMethod]
    public void MeuTeste()
    {
        Assert.IsTrue(true);
    }


    [TestInitialize]
    public void Inicializador()
    {
        meuValidador = new Validador();
        //File.WriteAllText(@"c:\temp\meu.txt", "executando");
    }


    [TestCleanup]
    public void Finalizador()
    {
        //
        //File.Delete(@"c:\temp\meu.txt");
    }
}