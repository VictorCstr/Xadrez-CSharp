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
                PartidaXadrez Partida = new();

                while (!Partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(Partida.Tab);

                    Console.Write("Origem da peça que você quer mexer: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ConverterParaPosicaoNaMatriz();

                    Console.Write("Destino da peça que você quer mexer: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ConverterParaPosicaoNaMatriz();

                    Partida.ExecutarMovimento(origem, destino);



                }

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