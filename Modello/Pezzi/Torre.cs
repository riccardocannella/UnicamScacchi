using System;

namespace Scacchi.Modello.Pezzi
{
    public class Torre : IPezzo
    {
        private readonly Colore colore;

        public Torre(Colore colore)
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

        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo)
        {
            var stessaColonna = colonnaPartenza == colonnaArrivo;
            var stessaTraversa = traversaPartenza == traversaArrivo;
            if (stessaColonna)
            {
                if (Math.Abs((int)traversaArrivo - (int)traversaPartenza) > 0)
                    return true;
                else return false;
            }
            else if (stessaTraversa)
            {
                if (Math.Abs((int)colonnaArrivo - (int)colonnaPartenza) > 0)
                    return true;
                else return false;
            }
            else return false;

        }
    }
}
