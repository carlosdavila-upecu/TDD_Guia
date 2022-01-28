namespace Katas
{
    public class Saludos
    {
        public static string Saludar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                return "Hola, amigo";
            if (nombre == nombre.ToUpper())
                return $"HOLA, {nombre}";
            return $"Hola, {nombre}";
        }
    }
}
