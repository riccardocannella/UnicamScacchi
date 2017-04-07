using System;

namespace Scacchi.Modello.Pezzi
{
    public class Alfiere : IPezzo
    {
        private readonly Colore colore;
        public Alfiere(Colore colore)
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
            var stessaColonna = colonnaPartenza == colonnaArrivo;
            var stessaTraversa = traversaPartenza == traversaArrivo;
            var distanzaTraLeTraverse = Math.Abs((int)traversaArrivo - (int)traversaPartenza);
            var distanzaTraLeColonne = Math.Abs((int)colonnaArrivo - (int)colonnaPartenza);
            if (stessaColonna || stessaTraversa) return false;
            else
                if (distanzaTraLeColonne == distanzaTraLeTraverse && distanzaTraLeColonne != 0) return true;
            else return false;
        }

    }
}