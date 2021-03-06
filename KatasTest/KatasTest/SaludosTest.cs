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
            const string nombres = "Carlos,Esteban";
            const string resultadoEsperado = "Hola, Carlos y Esteban";

            //Act
            var resultado = Saludos.Saludar(nombres);

            //Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void DeberiaDevolverSaludoAVariosNombresCuandoEnvioNombresSeparadosPorComas()
        {
            //Arrange
            const string nombres = "Carlos,Esteban,Daniel";
            const string resultadoEsperado = "Hola, Carlos, Esteban y Daniel";

            //Act
            var resultado = Saludos.Saludar(nombres);

            //Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void DeberiaDevolverSaludoAVariosNombresGritandoCuandoEnvioNombresSeparadosPorComasYAlgunoEsMayusculas()
        {
            //Arrange
            const string nombres = "Carlos,ESTEBAN,Daniel,LORENA";
            const string resultadoEsperado = "Hola, Carlos y Daniel Y HOLA, ESTEBAN Y LORENA";

            //Act
            var resultado = Saludos.Saludar(nombres);

            //Assert
            resultado.Should().Be(resultadoEsperado);
        }
    }
}
