using System;

namespace Scacchi.Modello.Pezzi
{
    public class Pedone : IPezzo
    {
        private readonly Colore colore;
        public Pedone(Colore colore)
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
            var distanzaTraLeTraverse = Math.Abs((int)traversaArrivo - (int)traversaPartenza);

            if (stessaColonna)
            {
                if (distanzaTraLeTraverse == 1)
                    return true;
                else if (this.colore == Colore.Bianco && traversaPartenza == Traversa.Seconda && distanzaTraLeTraverse == 2)
                    return true;
                else if (this.colore == Colore.Nero && traversaPartenza == Traversa.Settima && distanzaTraLeTraverse == 2)
                    return true;
                else return false;
            }
            else return false;

        }

    }
}