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

        [Fact]
        public void DeberiaDevolverSaludoComoAmigoCuandoEnvioStringNuloOVacio()
        {
            //Arrange
            const string nombre = "";
            const string resultadoEsperado = "Hola, amigo";

            //Act
            var resultado = Saludos.Saludar(nombre);

            //Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void DeberiaDevolverSaludoGritandoCuandoEnvioNombreEnMayusculas()
        {
            //Arrange
            const string nombre = "CARLOS";
            const string resultadoEsperado = "HOLA, CARLOS";

            //Act
            var resultado = Saludos.Saludar(nombre);

            //Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void DeberiaDevolverSaludoADosNombresCuandoEnvioNombresSeparadosPorComa()
        {
            //Arrange
            const string nombre = "Carlos,Esteban";
            const string resultadoEsperado = "Hola, Carlos y Esteban";

            //Act
            var resultado = Saludos.Saludar(nombre);

            //Assert
            resultado.Should().Be(resultadoEsperado);
        }
    }
}
