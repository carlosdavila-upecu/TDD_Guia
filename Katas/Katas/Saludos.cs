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
            else
                return $"Hola, {nombres[0]} y {nombres[1]}";
        }
    }
}
