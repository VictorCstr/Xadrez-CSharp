using Projeto_Xadrez.Entities.Tabuleiros;

namespace Projeto_Xadrez.Entities
{
    public static class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.PecasExistentes(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.PecasExistentes(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}