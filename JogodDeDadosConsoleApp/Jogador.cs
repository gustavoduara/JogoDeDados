using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodDeDadosConsoleApp
{
    class Jogador
    {
        public int posicao;
        public string nome; 

        public Jogador(string nomeJogador)
        {
          nome = nomeJogador;
        }

        public void AvancarPosicao(int resultadoLancamento)
        {
            posicao += resultadoLancamento;
        }

        public bool EstaNaPosicaoDeAvancoEspecial()
        {
            return posicao == 5 || posicao == 10 || posicao == 15 || posicao == 25;
        }

        public void AvancarPosicaoEspecial()
        {
            posicao += 3;
        }

        public bool EstaNaPosicaoDeRecuoEspecial()
        {
            return posicao == 7 || posicao == 13 || posicao == 20;
        }

        public void RecuarPosicaoEspecial()
        {
            posicao -= 2;
        }

        public bool UltrapassouNaLinhaDeChegada(int limiteLinhaChegada)
        {
            return posicao >= limiteLinhaChegada;
        }

    }
}
