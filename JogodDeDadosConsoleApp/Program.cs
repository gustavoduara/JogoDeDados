namespace JogodDeDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("______________________________________________________");
                Console.WriteLine("Jogo dos dados");
                Console.WriteLine("______________________________________________________");

                Console.Write("Pressione Enter para lançar o dado...");
                Console.ReadLine();

                Random geradorDeNumeros = new Random();

                int resultado = geradorDeNumeros.Next(1, 7);

                Console.WriteLine($"O número sorteado foi: {resultado}");

                Console.Write("Deseja continuar jogando? (s/n): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;

            }

        }
    }
}
