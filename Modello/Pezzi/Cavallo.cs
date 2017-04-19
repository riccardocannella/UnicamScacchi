using System;

<<<<<<< HEAD
namespace Scacchi.Modello.Pezzi
{
=======
namespace Scacchi.Modello.Pezzi {
>>>>>>> aff0a237bac06a74f1f44fe7544917def9cef194
    public class Cavallo : IPezzo
    {
        private readonly Colore colore;
        public Cavallo(Colore colore)
        {
<<<<<<< HEAD
            this.colore = colore;
        }
        public Colore Colore
        {
            get
            {
=======
            this.colore = colore;    
        }
        public Colore Colore {
            get {
>>>>>>> aff0a237bac06a74f1f44fe7544917def9cef194
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
            var distanzaTraLeTraverse = Math.Abs((int)traversaArrivo - (int)traversaPartenza);
            var distanzaTraLeColonne = Math.Abs((int)colonnaArrivo - (int)colonnaPartenza);
            if ((distanzaTraLeColonne == 2 && distanzaTraLeTraverse == 1) ||
                    (distanzaTraLeColonne == 1 && distanzaTraLeTraverse == 2))
                return true; // movimenti a L
            else return false;
        }

=======
            Traversa traversaArrivo,
            IScacchiera scacchiera = null)
        {
            var differenzaColonne = colonnaPartenza - colonnaArrivo;
            var differenzaTraverse = (int) traversaPartenza - (int) traversaArrivo;
            if(differenzaTraverse == 2 || differenzaTraverse == -2){
                if(differenzaColonne == 1 || differenzaColonne == -1){
                    return true;
                } else{
                    return false;
                }
            } else if(differenzaColonne == 2 || differenzaColonne == -2){
                
                if(differenzaTraverse == 1 || differenzaTraverse == -1){
                    return true;
                } else{
                    return false;
                }
            } else{
                return false;
            }
        }
>>>>>>> aff0a237bac06a74f1f44fe7544917def9cef194
    }
}