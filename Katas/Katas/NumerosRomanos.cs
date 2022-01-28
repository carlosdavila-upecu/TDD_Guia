using System.Text;

namespace Katas
{
    public class NumerosRomanos
    {
        private static readonly int[] Valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static readonly string[] Simbolos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        public static string ConvertirArabico(int numeroAConvertir)
        {
            var resultado = new StringBuilder();
            var restante = numeroAConvertir;
            for (int i = 0; i < Valores.Length; i++)
            {
                restante = agregarNumerosRomanos(restante, Valores[i], Simbolos[i], resultado);
            }
            return resultado.ToString();
        }

        private static int agregarNumerosRomanos(int arabico, int valorNumeroRomano, string digitosRomanos, StringBuilder stringBuilder)
        {
            int resultado = arabico;
            while (resultado >= valorNumeroRomano)
            {
                stringBuilder.Append(digitosRomanos);
                resultado -= valorNumeroRomano;
            }
            return resultado;
        }
    }
}
