using Xunit;
using NewTalents;

namespace TesteNewTalents
{
    public class TesteNewTalents
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int Num1, int Num2, int Resultado)
        {
            Calculadora calc = new Calculadora();

            int ResultadoCalculadora = calc.Somar(1, 2);

            Assert.Equal(Resultado, ResultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int Num1, int Num2, int Resultado)
        {
            Calculadora calc = new Calculadora();

            int ResultadoCalculadora = calc.Subtrair(1, 2);

            Assert.Equal(Resultado, ResultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int Num1, int Num2, int Resultado)
        {
            Calculadora calc = new Calculadora();

            int ResultadoCalculadora = calc.Multiplicar(1, 2);

            Assert.Equal(Resultado, ResultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int Num1, int Num2, int Resultado)
        {
            Calculadora calc = new Calculadora();

            int ResultadoCalculadora = calc.Dividir(1, 2);

            Assert.Equal(Resultado, ResultadoCalculadora);
        }

        [Fact]
        public void TesteDividirPorZero() 
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}