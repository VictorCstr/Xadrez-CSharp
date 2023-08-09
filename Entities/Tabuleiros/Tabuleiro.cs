using Projeto_Xadrez.Exceptions;

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

        public Peca PecasExistentes(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException($"Peça {p} na Posição {pos}, não é valida!");
            }
            Pecas[pos.Linha, pos.Coluna] = p;

            p.PosicaoPeca = pos;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Coluna < 0 || pos.Coluna > Colunas || pos.Linha < 0 || pos.Linha > Linhas)
            {
                return false;
            }
            return true;
        }


        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException($"Posição {pos}, não é valida!");
            }
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return PecasExistentes(pos) != null;
        }
    }
}