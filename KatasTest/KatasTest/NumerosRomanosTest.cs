using FluentAssertions;
using Katas;
using Xunit;

namespace KatasTest
{
    public class NumerosRomanosTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        public void DeberiaDevolverIsCuandoEnvioNumeroDel1Al3(int numeroAConvertir, string resultadoEsperado)
        {
            //Act
            var resultado = NumerosRomanos.ConvertirArabico(numeroAConvertir);

            //Assert
            resultado.Should().Be(resultadoEsperado);
        }
    }
}