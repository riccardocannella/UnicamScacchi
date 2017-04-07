using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class PezziTest
    {

        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Seconda,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Terza);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneNeroPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Settima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Sesta);

            //Then
            Assert.True(esito);
        }

        /*Se il Pedone si trova nella sua traversa
         di inizio (la seconda se il pedone è bianco o la settima 
         se il pedone è nero) può avanzare due case; */
        [Fact]
        public void IlPedoneNeroPuoMuovereAvantiDueCaselleSeInPosizioneIniziale()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Settima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Quinta
            );
            //Then
            Assert.True(esito);
        }
        /*Se il Pedone si trova nella sua traversa
        di inizio (la seconda se il pedone è bianco o la settima 
        se il pedone è nero) può avanzare due case; */
        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDueCaselleSeInPosizioneIniziale()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Seconda,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Quarta
            );
            //Then
            Assert.True(esito);
        }
        /*La Torre può spostarsi lungo una linea verticale o orizzontale di quante case desidera; */
        [Fact]
        public void LaTorrePuoMuovereInVerticaleDiQuanteCaselleVuole()
        {
            //Given
            Torre torre = new Torre(Colore.Bianco);
            //When
            bool esito = torre.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Ottava,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Prima
            );
            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaTorrePuoMuovereInOrizzontaleDiQuanteCaselleVuole()
        {
            //Given
            Torre torre = new Torre(Colore.Bianco);
            //When
            bool esito = torre.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Terza,
                colonnaArrivo: Colonna.H,
                traversaArrivo: Traversa.Terza
            );
            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaTorreNonPuoMuoversiInDiagonale()
        {
            //Given
            Torre torre = new Torre(Colore.Nero);
            //When
            bool esito = torre.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Ottava,
                colonnaArrivo: Colonna.B,
                traversaArrivo: Traversa.Prima
            );
            //Then
            Assert.False(esito);
        }

        /*L'Alfiere può spostarsi lungo una linea diagonale di quante case desidera;*/
        [Fact]
        public void LAlfiereNonPuoMuoversiOrizzontale()
        {
            //Given
            Alfiere alfiere = new Alfiere(Colore.Nero);
            //When
            bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.F,
                traversaArrivo: Traversa.Prima
            );
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void LAlfiereNonPuoMuoversiVerticale()
        {
            //Given
            Alfiere alfiere = new Alfiere(Colore.Nero);
            //When
            bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Settima
            );
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void LAlfiereNonPuoMuoversiACaso()
        {
            //Given
            Alfiere alfiere = new Alfiere(Colore.Bianco);
            //When
            bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.H,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Sesta
            );
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void LAlfierePuoMuoversiDiagonale()
        {
            //Given
            Alfiere alfiere = new Alfiere(Colore.Bianco);
            //When
            bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Quarta
            );
            //Then
            Assert.True(esito);
        }
    }
}