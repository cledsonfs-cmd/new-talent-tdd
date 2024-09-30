using NewTalents;

namespace TestNewTalents
{
    public class TestCalculadora
    {
        public Calculadora construirClasse()
        {
            string data = "30/9/2024";
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int val1, int val2, int _resultado)
        {
            Calculadora calc = construirClasse();

            int _resultadoCalculadora = calc.somar(val1, val2);

            Assert.Equal(_resultado, _resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void TestSubtrair(int val1, int val2, int _resultado)
        {
            Calculadora calc = construirClasse();

            int _resultadoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(_resultado, _resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int _resultado)
        {
            Calculadora calc = construirClasse();

            int _resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(_resultado, _resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int val1, int val2, int _resultado)
        {
            Calculadora calc = construirClasse();

            int _resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(_resultado, _resultadoCalculadora);
        }

        [Fact]
        public void TestDividiPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calc = construirClasse();

            calc.somar(1, 2);
            calc.somar(2, 3);
            calc.somar(3, 4);
            calc.somar(4, 5);

            var _lista = calc.historico();

            Assert.NotEmpty(_lista);
            Assert.Equal(3, _lista.Count);
        }
    }
}
