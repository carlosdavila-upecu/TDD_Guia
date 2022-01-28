using System.Text;

namespace Katas
{
    public class NumerosRomanos
    {
        private static readonly int[] Valores = { 9, 5, 4 };
        private static readonly string[] Simbolos = { "IX", "V", "IV" };
        public static string ConvertirArabico(int numeroAConvertir)
        {
            var resultado = new StringBuilder();
            var restante = numeroAConvertir;
            for (int i = 0; i < Valores.Length; i++)
            {
                restante = agregarNumerosRomanos(restante, Valores[i], Simbolos[i], resultado);
            }
            for (int i = 0; i < restante; i++)
            {
                resultado = resultado.Append("I");
            }
            return resultado.ToString();
        }

        private static int agregarNumerosRomanos(int arabico, int valorNumeroRomano, string digitosRomanos, StringBuilder stringBuilder)
        {
            int resultado = arabico;
            if(resultado >= valorNumeroRomano)
            {
                stringBuilder.Append(digitosRomanos);
                resultado -= valorNumeroRomano;
            }
            return resultado;
        }
    }
}
