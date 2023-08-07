using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Xadrez.Entities.Tabuleiros;

namespace Projeto_Xadrez.Entities.Tabuleiros
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] Pecas;


        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca PecasExistentes(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
    }
}