using NewTalents;
namespace TestNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (1,2,3)]
        [InlineData (4, 5, 9)]
        public void TestSomar(int val1, int val2 , int _resultado)
        {
            Calculadora calc = new Calculadora();

            int _resultadoCalculadora = calc.somar(val1,val2);

            Assert.Equal(_resultado, _resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int _resultado)
        {
            Calculadora calc = new Calculadora();

            int _resultadoCalculadora = calc.somar(val1, val2);

            Assert.Equal(_resultado, _resultadoCalculadora);
        }

    }
}