using Projeto_Xadrez.Entities.Tabuleiros;

namespace Projeto_Xadrez.Entities.Xadrez
{
    public class PartidaXadrez
    {
        public Tabuleiro Tab { get; }
        private int Turno;
        private Cor Jogador;
        public bool Terminada { get; }

        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 0;
            Jogador = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);

            p.IncrementarMovimentos();

            Peca pecaCapturada = Tab.RetirarPeca(destino);

            Tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 1).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 2).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('d', 2).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('e', 2).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('e', 1).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('d', 1).ConverterParaPosicaoNaMatriz());


            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 7).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 8).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('d', 7).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('e', 7).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('e', 8).ConverterParaPosicaoNaMatriz());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('d', 8).ConverterParaPosicaoNaMatriz());
        }
    }
}