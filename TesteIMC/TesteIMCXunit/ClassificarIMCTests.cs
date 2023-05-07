using Xunit;
using TesteIMC;

namespace TesteIMCXunit
{
    public class ClassificarIMCTests
    {
        [Fact]
        public void ClassificarIMC()
        {
            double imc = 28;

            var resultado = Operacoes.ClassificarIMC(imc);

            Assert.Equal("Sobrepeso", resultado);
        }
        [Theory]
        [InlineData(27, "Sobrepeso")]
        [InlineData(32, "Obesidade I")]
        public void ClassificarIMC_Retorna_Para_Lista(double primeiroNumero, string resultadoEsperado)
        {
            var resultadoDoImc = Operacoes.ClassificarIMC(primeiroNumero);
            Assert.Equal(resultadoEsperado, resultadoDoImc);
        }
    }
}
