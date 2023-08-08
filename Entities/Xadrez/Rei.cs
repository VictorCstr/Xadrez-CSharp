using Projeto_Xadrez.Entities.Tabuleiros;

namespace Projeto_Xadrez.Entities.Xadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "R";
        }
    }
}