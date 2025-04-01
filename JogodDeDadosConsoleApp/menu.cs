using System;
using System.Collections.Generic;
using System.Linq;
namespace JogoDosDados;

// Responsável por apresentar interações com o usuário
public class Menu
{
    public void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Rodada do Usuário");
        Console.WriteLine("----------------------------------");
        Console.Write("Pressione ENTER para lançar o dado...");
        Console.ReadLine();
    }

    public void ExibirResultadoSorteio(int resultadoUsuario)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"O valor sorteado foi: {resultadoUsuario}!");
        Console.WriteLine("----------------------------------");
    }


    public void ExibirPosicaoJogador(int limiteLinhaChegada, int posicaoUsuario)
    {
        Console.WriteLine($"Você está na posição: {posicaoUsuario} de {limiteLinhaChegada}!");
    }

    public void ExibirMensagemAvancoEspecial()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
    }

    public void ExibirPosicaoAvancoEspecial(int posicaoUsuario)
    {
        Console.WriteLine($"Você avançou para a posição: {posicaoUsuario}!");
        Console.WriteLine("----------------------------------");
    }

    public void ExibirMensagemRecuoEspecial()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
    }

    public void ExibirPosicaoRecuoEspecial(int posicaoUsuario)
    {
        Console.WriteLine($"Você recuou para a posição: {posicaoUsuario}!");
        Console.WriteLine("----------------------------------");
    }

    public void ExibirMensagemVitoria()
    {
        Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");
    }
}