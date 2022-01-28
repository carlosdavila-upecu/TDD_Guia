using System.Text;

namespace Katas
{
    public class NumerosRomanos
    {
        public static string ConvertirArabico(int numeroAConvertir)
        {
            var resultado = new StringBuilder();
            if (numeroAConvertir == 4)
                resultado.Append("IV");
            else
            {
                for (int i = 0; i < numeroAConvertir; i++)
                {
                    resultado = resultado.Append("I");
                }
            }
            return resultado.ToString();
        }
    }
}
