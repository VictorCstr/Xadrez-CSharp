using Projeto_Xadrez.Entities.Tabuleiros;

namespace Projeto_Xadrez.Entities.Xadrez
{
    public class PosicaoXadrez
    {
        public int Linha { get; set; }
        public char Coluna { get; set; }


        public PosicaoXadrez(int linha, char coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public Posicao ConverterParaPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}