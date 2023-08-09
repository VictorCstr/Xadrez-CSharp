using Projeto_Xadrez.Entities.Tabuleiros;
using Projeto_Xadrez.Entities.Xadrez;

namespace Projeto_Xadrez.Entities
{
    public static class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(tab.Linhas - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {

                    if (tab.PecasExistentes(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Peca peca = tab.PecasExistentes(i, j);
                        Console.Write(ImprimirPeca(peca));
                        Console.Write(" ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine();
            }
            Console.Write("  A B C D E F G H ");
        }

        public static Peca ImprimirPeca(Peca peca)
        {

            if (peca.CorPeca == Cor.Branca)
            {
                return peca;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return peca;
            }
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine()!;

            char coluna = s[0];

            int linha = int.Parse(s[1] + " ");

            return new PosicaoXadrez(coluna, linha);
        }
    }
}