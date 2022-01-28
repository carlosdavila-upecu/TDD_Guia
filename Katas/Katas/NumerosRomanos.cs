using System.Text;

namespace Katas
{
    public class NumerosRomanos
    {
        public static string ConvertirArabico(int numeroAConvertir)
        {
            var resultado = new StringBuilder();
            var restante = numeroAConvertir;
            restante = agregarNumerosRomanos(restante, 9, "IX", resultado);
            restante = agregarNumerosRomanos(restante, 5, "V", resultado);
            restante = agregarNumerosRomanos(restante, 4, "IV", resultado);
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
