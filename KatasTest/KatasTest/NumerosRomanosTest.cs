using FluentAssertions;
using Katas;
using Xunit;

namespace KatasTest
{
    public class NumerosRomanosTest
    {
        [Fact]
        public void DeberiaDevolerICuandoEnvio1()
        {
            //Arrange
            const string resultadoEsperado = "I";
            const int numeroAConvertir = 1;

            //Act
            var resultado = NumerosRomanos.ConvertirArabico(numeroAConvertir);

            //Assert
            resultado.Should().Be(resultadoEsperado);
        }
    }
}