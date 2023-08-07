using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Xadrez.Entities.Tabuleiros
{
    public class Peca
    {
        public Posicao PosicaoPeca { get; set; }
        public Cor CorPeca { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            PosicaoPeca = posicao;
            CorPeca = cor;
            Tab = tab;
            QuantidadeMovimentos = 0;

        }
    }
}