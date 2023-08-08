using Projeto_Xadrez.Entities.Tabuleiros;

namespace Projeto_Xadrez.Entities.Xadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            PosicaoPeca = null!;
            Tab = tab;
            CorPeca = cor;
            QuantidadeMovimentos = 0;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}