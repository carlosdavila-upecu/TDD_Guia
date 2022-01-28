using System.Linq;

namespace Katas
{
    public class Saludos
    {
        public static string Saludar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                nombre = "amigo";
            var nombres = nombre.Split(",");
            if(nombres.Length == 1)
            {
                if (esNombreMayusculas(nombres[0]))
                    return gritarUnNombre(nombres[0]);
                return $"Hola, {nombres[0]}";
            }

            var nombresMinusculas = nombres.Where(n => !esNombreMayusculas(n)).ToArray();
            var ultimoNombreMinusculas = nombresMinusculas.Last();
            var nombresAcumuladosMinusculas = nombresMinusculas.SkipLast(1)
                .Aggregate((i, j) => i + ", " + j);
            var textoMinusculas = $"Hola, {nombresAcumuladosMinusculas} y {ultimoNombreMinusculas}";


            var nombresMayusculas = nombres.Where(esNombreMayusculas).ToArray();
            string textoMayusculas = "";
            if (nombresMayusculas.Length == 1)
                textoMayusculas = $"Y {gritarUnNombre(nombresMayusculas[0])}";
            else if(nombresMayusculas.Length > 1)
            {
                var ultimoNombreMayusculas = nombresMayusculas.Last();
                var nombresAcumuladosMayusculas = nombresMayusculas.SkipLast(1)
                    .Aggregate((i, j) => i + ", " + j);
                textoMayusculas = $"Y HOLA, {nombresAcumuladosMayusculas} Y {ultimoNombreMayusculas}";
            }

            return string.IsNullOrEmpty(textoMayusculas) ?
                textoMinusculas : $"{textoMinusculas} {textoMayusculas}";

        }

        private static string gritarUnNombre(string nombre) => $"HOLA, {nombre}";

        private static bool esNombreMayusculas(string nombre) => nombre == nombre.ToUpper();
    }
}
