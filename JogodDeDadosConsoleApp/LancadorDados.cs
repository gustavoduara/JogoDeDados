
namespace JogodDeDadosConsoleApp
{
    public class LancadorDados
    {
        public int SortearDado()
        {
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;
        }
    }
}
