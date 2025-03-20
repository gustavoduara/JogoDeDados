namespace JogodDeDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int LimiteLinhaChegada = 30;

            while (true)
            {
                int posicaoUsuario = 0;
                int posicaoComputador = 0;

                bool JogoEmAndamento = true;

                while(JogoEmAndamento)
                {
                    Console.Clear();
                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("Jogo dos dados");
                    Console.WriteLine("/n______________________________________________________");
                    Console.WriteLine("Turno do usuario");
                    Console.WriteLine("______________________________________________________");
                    Console.Write("Pressione Enter para lançar o dado...");
                    Console.ReadLine();

                    int resultadoUsuario = SortearDado();

                   
                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine($"O número sorteado foi: {resultadoUsuario}");
                    Console.WriteLine("______________________________________________________");

                    posicaoUsuario+= resultadoUsuario;

                    Console.WriteLine($"Voce esta na posição {posicaoUsuario} de {LimiteLinhaChegada}.");

                    if (posicaoUsuario == 5 || posicaoUsuario == 10 || posicaoUsuario == 15 || posicaoUsuario == 20 || posicaoUsuario == 25)
                    {
                        Console.WriteLine("______________________________________________________");
                        Console.WriteLine("EVENTO ESPECIAL: AVANÇO EXTRA DE 3 CASAS");


                        posicaoUsuario += 3;

                        Console.WriteLine($"Voce esta na posição {posicaoUsuario}!");
                    }
                    else if (posicaoUsuario == 7  || posicaoUsuario == 13 || posicaoUsuario == 20)
                    {
                        Console.WriteLine("______________________________________________________");
                        Console.WriteLine("EVENTO ESPECIAL: RECUE 2 CASAS");

                        posicaoUsuario -= 2;

                        Console.WriteLine($"recuou para a posição {posicaoUsuario}!");
                        Console.WriteLine("______________________________________________________");
                    }

                    if (posicaoUsuario >= LimiteLinhaChegada)
                    {
                        
                        Console.WriteLine("Parabens você chegou na linha de chegada");
                       
                        JogoEmAndamento = false;
                        continue;
                    }

                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("Turno do Computador");
                    Console.WriteLine("______________________________________________________");
                    Console.Write("Pressione Enter para visualizar a rodada do computador...");
                    Console.ReadLine();

                    int resultadoComputador = SortearDado();

                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine($"O número sorteado foi: {resultadoComputador}");
                    Console.WriteLine("______________________________________________________");

                    posicaoComputador += resultadoComputador;

                    Console.WriteLine($"O computador esta na posição: {posicaoComputador} de {LimiteLinhaChegada}.");

                    if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 20 || posicaoComputador == 25)
                    {
                        Console.WriteLine("______________________________________________________");
                        Console.WriteLine("EVENTO ESPECIAL: AVANÇO EXTRA DE 3 CASAS");


                        posicaoComputador += 3;

                        Console.WriteLine("____________________________________");
                        Console.WriteLine($"O computador avançou para a posição {posicaoComputador}!");
                        Console.WriteLine("____________________________________");
                    }
                    else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                    {
                        Console.WriteLine("______________________________________________________");
                        Console.WriteLine("EVENTO ESPECIAL: RECUE 2 CASAS");

                        posicaoComputador -= 2;

                        Console.WriteLine("____________________________________");
                        Console.WriteLine($"O computador recuou para a posição {posicaoComputador}!");
                        Console.WriteLine("______________________________________________________");

                }
                    }

                    if (posicaoUsuario >= LimiteLinhaChegada)
                    {

                        Console.WriteLine("____________________________________");
                        Console.WriteLine("Que pena! O computador alcançou na linha de chegada");
                        Console.WriteLine("____________________________________");

                    JogoEmAndamento = false;
                        continue;
                    }

                    Console.ReadLine();

                Console.WriteLine("____________________________________");
                Console.Write("Deseja continuar jogando? (s/n): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;

            }

        }

        static int SortearDado()
        {
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;

           
        }
    }
}
