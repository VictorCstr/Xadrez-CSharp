using System;
using System.Globalization;
using Projeto_Xadrez.Entities.Tabuleiros;

namespace Projeto_Xadrez // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Posicao p = new Posicao(3, 4);
            System.Console.WriteLine(p);

        }

    }
}