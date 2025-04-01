using JogodDeDadosConsoleApp;

namespace JogoDosDados
{
    // Versão 5 - Implementação Orientada a Objetos
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                Menu menu = new Menu();
                LancadorDados lancadorDados = new LancadorDados();

                Jogador usuario = new Jogador("Usuario");

                Jogador computador = new Jogador("Usuario");

                Jogador[]jogadores = [usuario, computador];

                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    for(int contadorJogador = 0; contadorJogador < jogadores.Length; contadorJogador++)
                    {

                        Jogador jogadorAtual = jogadores[contadorJogador];

                        menu.ExibirCabecalho();

                        int resultadoUsuario = lancadorDados.SortearDado();

                        menu.ExibirResultadoSorteio(resultadoUsuario);

                        jogadorAtual.AvancarPosicao(resultadoUsuario);

                        menu.ExibirPosicaoJogador(limiteLinhaChegada, jogadorAtual.posicao);

                        if (jogadorAtual.EstaNaPosicaoDeAvancoEspecial())
                        {
                            menu.ExibirMensagemAvancoEspecial();

                            jogadorAtual.AvancarPosicaoEspecial();

                            menu.ExibirPosicaoAvancoEspecial(jogadorAtual.posicao);
                        }
                        else if (jogadorAtual.EstaNaPosicaoDeRecuoEspecial())
                        {
                            menu.ExibirMensagemRecuoEspecial();

                            jogadorAtual.RecuarPosicaoEspecial();

                            menu.ExibirPosicaoRecuoEspecial(jogadorAtual.posicao);
                        }

                        if (jogadorAtual.UltrapassouNaLinhaDeChegada(limiteLinhaChegada))
                        {
                            menu.ExibirMensagemVitoria();

                            jogoEmAndamento = false;
                            continue;
                        }
                        Console.ReadLine();
                    }
                }

                    

                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}