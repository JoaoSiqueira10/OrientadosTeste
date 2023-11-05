using Xunit;
using NewTalents;

namespace TesteNewTalents
{
    public class TesteNewTalents
    {
        public Calculadora ConstruirClasse()
        {
            string Data = "02/02/2020";
            Calculadora Calc = new Calculadora("02/02/2020");
            return Calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int Num1, int Num2, int Resultado)
        {
            Calculadora calc = ConstruirClasse();

            int ResultadoCalculadora = calc.Somar(Num1, Num2);

            Assert.Equal(Resultado, ResultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int Num1, int Num2, int Resultado)
        {
            Calculadora calc = ConstruirClasse();

            int ResultadoCalculadora = calc.Subtrair(Num1, Num2);

            Assert.Equal(Resultado, ResultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int Num1, int Num2, int Resultado)
        {
            Calculadora calc = ConstruirClasse();

            int ResultadoCalculadora = calc.Multiplicar(Num1, Num2);

            Assert.Equal(Resultado, ResultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int Num1, int Num2, int Resultado)
        {
            Calculadora calc = ConstruirClasse();

            int ResultadoCalculadora = calc.Dividir(Num1, Num2);

            Assert.Equal(Resultado, ResultadoCalculadora);
        }

        [Fact]
        public void TesteDividirPorZero() 
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = ConstruirClasse();

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