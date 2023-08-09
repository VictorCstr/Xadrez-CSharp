using Projeto_Xadrez.Entities;
using Projeto_Xadrez.Entities.Tabuleiros;
using Projeto_Xadrez.Entities.Xadrez;
using Projeto_Xadrez.Exceptions;

namespace Projeto_Xadrez // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Tabuleiro tab = new(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(6, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(6, 7));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.Write(e.Message);
            }
            catch (ApplicationException e)
            {
                Console.Write(e.Message);
            }


        }

    }
}