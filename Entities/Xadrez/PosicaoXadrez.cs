using Projeto_Xadrez.Entities.Tabuleiros;

namespace Projeto_Xadrez.Entities.Xadrez
{
    public class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ConverterParaPosicaoNaMatriz()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return $"{Coluna}{Linha}";
        }
    }
}