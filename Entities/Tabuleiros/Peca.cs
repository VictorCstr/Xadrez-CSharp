namespace Projeto_Xadrez.Entities.Tabuleiros
{
    public class Peca
    {
        public Posicao PosicaoPeca { get; set; }
        public Cor CorPeca { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            PosicaoPeca = null!;
            Tab = tab;
            CorPeca = cor;
            QuantidadeMovimentos = 0;
        }

        public void IncrementarMovimentos()
        {
            QuantidadeMovimentos++;
        }

        public override string ToString()
        {
            return "P";
        }

    }
}