using System;

namespace Scacchi.Modello.Pezzi
{
    public class Re : IPezzo
    {
        private readonly Colore colore;
        public Re(Colore colore)
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
            // controllo che il movimento sia di 1 casa
            if ((distanzaTraLeColonne == 1 && distanzaTraLeTraverse == 1) ||
                    (distanzaTraLeColonne == 0 && distanzaTraLeTraverse == 1) ||
                    (distanzaTraLeColonne == 1 && distanzaTraLeTraverse == 0))
            {
                if (stessaColonna || stessaTraversa) return true; // movimenti orizz e vert
                else
                if (distanzaTraLeColonne == distanzaTraLeTraverse && distanzaTraLeColonne != 0) return true; //movimenti diag
                else return false;
            }
            else return false;

        }

    }
}