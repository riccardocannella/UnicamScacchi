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
<<<<<<< HEAD
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

=======
            Traversa traversaArrivo,
            IScacchiera scacchiera = null)
        {
            var differenzaColonne = colonnaPartenza - colonnaArrivo;
            var differenzaTraverse = (int)traversaPartenza - (int)traversaArrivo;
            if (differenzaColonne == 0 && differenzaTraverse == 0)
                return false;
            if ((Math.Abs(differenzaColonne) - Math.Abs(differenzaTraverse)) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
>>>>>>> aff0a237bac06a74f1f44fe7544917def9cef194
    }
}