using System;

namespace Scacchi.Modello.Pezzi
{
    public class Cavallo : IPezzo
    {
        private readonly Colore colore;
        public Cavallo(Colore colore)
        {
            this.colore = colore;
        }
        public Colore Colore
        {
            get
            {
                return colore;
            }
        }
        public bool PuòMuovere(
            Colonna colonnaPartenza,
            Traversa traversaPartenza,
            Colonna colonnaArrivo,
            Traversa traversaArrivo)
        {
            var distanzaTraLeTraverse = Math.Abs((int)traversaArrivo - (int)traversaPartenza);
            var distanzaTraLeColonne = Math.Abs((int)colonnaArrivo - (int)colonnaPartenza);
            if ((distanzaTraLeColonne == 2 && distanzaTraLeTraverse == 1) ||
                    (distanzaTraLeColonne == 1 && distanzaTraLeTraverse == 2))
                return true; // movimenti a L
            else return false;
        }

    }
}