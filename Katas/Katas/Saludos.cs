using System.Linq;

namespace Katas
{
    public class Saludos
    {
        public static string Saludar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                return "Hola, amigo";
            var nombres = nombre.Split(",");
            if (nombres[0] == nombres[0].ToUpper())
                return $"HOLA, {nombre}";
            if(nombres.Length == 1)
                return $"Hola, {nombres[0]}";
            var ultimoNombre = nombres.Last();
            var nombresAcumulados = nombres.SkipLast(1)
                .Aggregate((i, j) => i + ", " + j);
            return $"Hola, {nombresAcumulados} y {ultimoNombre}";
        }
    }
}
