namespace JogodDeDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int LimiteLinhaChegada = 30;

            while (true)
            {
                int posicaoJogador = 0;
                bool JogoEmAndamento = true;

                while(JogoEmAndamento)
                {
                    Console.Clear();
                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("Jogo dos dados");
                    Console.WriteLine("______________________________________________________");

                    Console.Write("Pressione Enter para lançar o dado...");
                    Console.ReadLine();

                    Random geradorDeNumeros = new Random();

                    int resultado = geradorDeNumeros.Next(1, 7);

                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine($"O número sorteado foi: {resultado}");
                    Console.WriteLine("______________________________________________________");

                    posicaoJogador+= resultado;

                    if (posicaoJogador >= LimiteLinhaChegada)
                    {
                        JogoEmAndamento = false;

                        Console.WriteLine("Parabens você chegou na linha de chegada");
                        Console.WriteLine("______________________________________________________");
                    }
                    else
                        Console.WriteLine($"Voce esta na posição {posicaoJogador} de {LimiteLinhaChegada}.");
                   
                    Console.WriteLine("______________________________________________________");
                    Console.ReadLine();
                }

                Console.Write("Deseja continuar jogando? (s/n): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;

            }

        }
    }
}
