using System;
using System.Collections.Generic;
using System.Linq;
using Scacchi.Modello;
using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Tests
{

    public class ScacchieraTest
    {

        [Fact]
        public void ScacchieraDeveAvere64Case()
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When

            //Then
            Assert.Equal(64, scacchiera.Case.Count());
        }
        [Fact]
        public void indexerDeveRestituireCasaCorretta()
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When
            ICasa casa = scacchiera[Colonna.F, Traversa.Quinta];
            //Then
            Assert.Equal(Colonna.F, casa.Colonna);
            Assert.Equal(Traversa.Quinta, casa.Traversa);
        }
        [Fact]
        public void InSecondaTraversaDevonoEsserciTuttiPedoniBianchi()
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When
            IEnumerable<ICasa> inSecondaTraversa = scacchiera.Case.Where(casa => casa.Traversa == Traversa.Seconda);
            bool sonoTuttiPedoniBianchi = inSecondaTraversa.All(casa => casa.PezzoPresente is Pedone && casa.PezzoPresente.Colore == Colore.Bianco);
            //Then
            /*for (int i = 0; i<9; i++){
                Assert.IsType(typeof(Pedone), scacchiera[(Colonna) i , Traversa.Seconda].PezzoPresente);*/
            Assert.True(sonoTuttiPedoniBianchi);
        }
        [Fact]
        public void DeveEsistereUnSoloReBiancoInPosizioneE1()
        {
        //Given
        IScacchiera scacchiera = new Scacchiera();
        //When
        IEnumerable<ICasa> caseConReBianco = scacchiera.Case.Where(casa => casa.PezzoPresente is Re && casa.PezzoPresente.Colore == Colore.Bianco);
        //Then
        Assert.Equal(1, caseConReBianco.Count());
        Assert.Equal(Colonna.E, caseConReBianco.First().Colonna);
        Assert.Equal(Traversa.Prima, caseConReBianco.First().Traversa);
        }

        [Theory]
        [InlineData(typeof(Torre),Colore.Bianco, Colonna.A,Traversa.Prima)]
        [InlineData(typeof(Cavallo),Colore.Bianco, Colonna.B,Traversa.Prima)]
        [InlineData(typeof(Alfiere),Colore.Bianco, Colonna.C,Traversa.Prima)]
        [InlineData(typeof(Re),Colore.Bianco, Colonna.E,Traversa.Prima)]
        [InlineData(typeof(Donna),Colore.Bianco, Colonna.D,Traversa.Prima)]
        [InlineData(typeof(Torre),Colore.Nero, Colonna.A,Traversa.Ottava)]
        [InlineData(typeof(Cavallo),Colore.Nero, Colonna.B,Traversa.Ottava)]
        [InlineData(typeof(Alfiere),Colore.Nero, Colonna.C,Traversa.Ottava)]
        [InlineData(typeof(Re),Colore.Nero, Colonna.E,Traversa.Ottava)]
        [InlineData(typeof(Donna),Colore.Nero, Colonna.D,Traversa.Ottava)]
        public void BOH(Type tipoDiPezzo, Colore colore, Colonna colonna, Traversa traversa)
        {
        //Given
        IScacchiera scacchiera = new Scacchiera();
        //When
        scacchiera.Case.Single(casa => 
        casa.PezzoPresente != null 
        && casa.PezzoPresente.GetType() == tipoDiPezzo 
        && casa.PezzoPresente.Colore==colore 
        && casa.Traversa == traversa 
        && casa.Colonna == colonna);
        //Then
        }
    }

}


