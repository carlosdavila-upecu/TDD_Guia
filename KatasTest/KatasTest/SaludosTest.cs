using FluentAssertions;
using Katas;
using Xunit;

namespace KatasTest
{
    public class SaludosTest
    {
        [Fact]
        public void DeberiaDevolverSaludoCuandoEnvioNombre()
        {
            //Arrange
            const string nombre = "Carlos";
            const string resultadoEsperado = "Hola, Carlos";

            //Act
            var resultado = Saludos.Saludar(nombre);

            //Assert
            resultado.Should().Be(resultadoEsperado);
        }
    }
}
