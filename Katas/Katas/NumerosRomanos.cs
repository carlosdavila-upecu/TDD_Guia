using System.Text;

namespace Katas
{
    public class NumerosRomanos
    {
        public static string ConvertirArabico(int numeroAConvertir)
        {
            var resultado = new StringBuilder();
            var restante = numeroAConvertir;
            if (restante >= 9)
            {
                resultado.Append("IX");
                restante -= 9;
            }
            if (restante >= 5)
            {
                resultado.Append("V");
                restante -= 5;
            }
            if (restante >= 4)
            {
                resultado.Append("IV");
                restante -= 4;
            }
            for (int i = 0; i < restante; i++)
            {
                resultado = resultado.Append("I");
            }
            return resultado.ToString();
        }
    }
}
