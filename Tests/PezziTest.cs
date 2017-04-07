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

        /*La Donna può spostarsi lungo una linea verticare,
         orizzontale o diagonale di quante case desidera; */
        [Fact]
        public void LaDonnaPuoMuoversiDiagonale()
        {
            //Given
            Donna donna = new Donna(Colore.Bianco);
            //When
            bool esito = donna.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Quarta
            );
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LaDonnaPuoMuoversiOrizzontale()
        {
            //Given
            Donna donna = new Donna(Colore.Bianco);
            //When
            bool esito = donna.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Quarta
            );
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LaDonnaPuoMuoversiVerticale()
        {
            //Given
            Donna donna = new Donna(Colore.Nero);
            //When
            bool esito = donna.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Prima
            );
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LaDonnaNonPuoMuoversiACaso()
        {
            //Given
            Donna donna = new Donna(Colore.Nero);
            //When
            bool esito = donna.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Sesta
            );
            //Then
            Assert.False(esito);
        }

        /*Il Cavallo può spostarsi con un movimento ad "L", ovvero una casa orizzontalmente 
        e due verticalmente; oppure, due orizzontalmente e una verticalmente; */
        [Fact]
        public void IlCavalloPuoMuoversiAElleVerticale()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Bianco);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Terza
            );
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void IlCavalloPuoMuoversiAElleOrizzontale()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Bianco);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Seconda
            );
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void IlCavalloNonPuoMuoversiOrizzontale()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Nero);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.B,
                traversaArrivo: Traversa.Terza
            );
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void IlCavalloNonPuoMuoversiVerticale()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Bianco);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Prima
            );
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void IlCavalloNonPuoMuoversiDiagonale()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Bianco);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Terza
            );
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void IlCavalloNonPuoMuoversiACaso()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Bianco);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.B,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Terza
            );
            //Then
            Assert.False(esito);
        }

        /*Il Re può spostarsi orizzontalmente, verticalmente 
        o diagonalmente di una sola casa. */
        [Fact]
        public void IlRePuoMuovereVerticaleUnaCasa(){
            //Given
            Re re = new Re(Colore.Bianco);
            //When
            bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Seconda
            );
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void IlRePuoMuovereOrizzontaleUnaCasa(){
            //Given
            Re re = new Re(Colore.Bianco);
            //When
            bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Prima
            );
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void IlRePuoMuovereDiagonaleUnaCasa(){
            //Given
            Re re = new Re(Colore.Bianco);
            //When
            bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Seconda
            );
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void IlReNonPuoMuovereVerticalePiuDiUnaCasa(){
            //Given
            Re re = new Re(Colore.Bianco);
            //When
            bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Terza
            );
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void IlReNonPuoMuovereOrizzontalePiuDiUnaCasa(){
            //Given
            Re re = new Re(Colore.Bianco);
            //When
            bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.F,
                traversaArrivo: Traversa.Prima
            );
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void IlReNonPuoMuovereDiagonalePiuDiUnaCasa(){
            //Given
            Re re = new Re(Colore.Bianco);
            //When
            bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.F,
                traversaArrivo: Traversa.Quarta
            );
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void IlReNonPuoMuovereACaso(){
            //Given
            Re re = new Re(Colore.Bianco);
            //When
            bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo: Colonna.F,
                traversaArrivo: Traversa.Settima
            );
            //Then
            Assert.False(esito);
        }
    }
}