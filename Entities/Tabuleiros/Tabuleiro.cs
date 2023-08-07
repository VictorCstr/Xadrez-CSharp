using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Xadrez.Entities.Tabuleiros
{
    public class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public Peca[,] pecas;


        public Tabuleiro(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            pecas = new Peca[linha, coluna];
        }
    }
}