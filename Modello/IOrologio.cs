using System;

namespace Scacchi.Modello {
    public interface IOrologio {
        TimeSpan TempoResiduoBianco {get;}
        TimeSpan TempoResiduoNero {get;}
        Colore TurnoAttuale {get;}
        TimeSpan TempoIniziale {get;}

        void Accendi();
        void Avvia();
        void Pausa();
        void Reset();
        void FineTurno();
<<<<<<< HEAD

=======
>>>>>>> aff0a237bac06a74f1f44fe7544917def9cef194
        event EventHandler<Colore> TempoScaduto;
    }
}