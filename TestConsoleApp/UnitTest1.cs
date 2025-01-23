using System;
using ConsoleApp;
using Xunit;

namespace TestConsoleApp
{


    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            Calculadora calculadora = new Calculadora(DateTime.Now);
            return calculadora;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        [InlineData(5, 3, 8)]
        [InlineData(5, 5, 10)]
        public void TestSomar_DoisValoresInteiros_ComparacaoDeResultado(int val1, int val2, int resultado)
        {
            //Arrange
            Calculadora calc = ConstruirClasse();
            //Act
            var resultCalc = calc.Somar(val1, val2);
            //Assert
                Assert.Equal(resultado,resultCalc);
        }
        
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(3, 2, 1)]
        [InlineData(5, 3, 2)]
        [InlineData(7, 3, 4)]
        public void TestSubtrair_DoisValoresInteiros_ComparacaoDeResultado(int val1, int val2, int resultado)
        {
            //Arrange
                Calculadora calc = ConstruirClasse();
            //Act
               var resultCalc = calc.Subtrair(val1, val2);
            //Assert
                Assert.Equal(resultado,resultCalc);
        } 


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(3, 2, 6)]
        [InlineData(5, 3, 15)]
        [InlineData(7, 3, 21)]
        public void TestMultiplicar_DoisValoresInteiros_ComparacaoDeResultado(int val1, int val2, int resultado)
        {
            //Arrange
                Calculadora calc = ConstruirClasse();
            //Act
               var resultCalc = calc.Multiplicar(val1, val2);
            //Assert
                Assert.Equal(resultado,resultCalc);
        }

        [Theory]
        [InlineData(11, 2, 5)]
        [InlineData(3, 2, 1)]
        [InlineData(5, 2, 2)]
        [InlineData(9, 3, 3)]
        public void TestDividir_DoisValoresInteiros_ComparacaoDeResultado(int val1, int val2, int resultado)
        {
            //Arrange
                Calculadora calc = ConstruirClasse();
            //Act
               var resultCalc = calc.Dividir(val1, val2);
            //Assert
                Assert.Equal(resultado,resultCalc);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            //Arrange
                Calculadora calc = ConstruirClasse();
            //Act Assert
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }
        
        [Fact]
        public void TestHistorico()
        {
            //Arrange
                Calculadora calc = ConstruirClasse();
                calc.Somar(2, 3);
                calc.Somar(5, 5);
                calc.Somar(7, 3);
                calc.Somar(2, 9);
                calc.Somar(2, 9);

            //Act
                var result = calc.RetornarHistorico();

            //Assert
                Assert.NotEmpty(result);
                Assert.Equal(3, result.Count);
        }

    }
}
