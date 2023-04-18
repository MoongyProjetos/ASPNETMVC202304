using Exemplo.Common.ErrorHandling;
using Exemplo.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Tests
{
    [TestClass]
    public class PagamentoTests
    {
        [TestMethod]
        public void Exemplo()
        {
            //Arrange
            IPagamento pgto = new PaypalFake();

            //Act
            var resultado = pgto.ValidarPagamento(1000M);


            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidarException()
        {
            //Arrange
            var pagamento = new PaypalAdapter(); //Usamos implementacao concreta para poupar tempo. Evitar e usar injecao de dependencia
            
            //Act
            pagamento.ValidarPagamento(-1);

        }


        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ValidarDividePorZeroException()
        {
            //Arrange
            var pagamento = new PaypalAdapter(); //Usamos implementacao concreta para poupar tempo. Evitar e usar injecao de dependencia

            //Act
            pagamento.ValidarPagamento(0);
        }


        [DataTestMethod]
        [DataRow(0, typeof(DivideByZeroException))]
        [DataRow(-1, typeof(ArgumentException))]
        [DataRow(21, typeof(NumberNotValidException))]
        public void ValidarExceptionAleatorias(int valor, Type typeOfException)
        {
            //Arrange
            var pagamento = new PaypalAdapter(); //Usamos implementacao concreta para poupar tempo. Evitar e usar injecao de dependencia

            //Act
            try
            {
                pagamento.ValidarPagamento(valor);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual(typeOfException, ex.GetType());
            }
        }
    }
}
