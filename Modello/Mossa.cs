namespace Scacchi.Modello{
    public class Mossa {
        public int Id {get; set;}
        public Coordinata CasaPartenza {get; private set;}
        public Coordinata CasaArrivo {get; private set;}
        public override string ToString(){
            return CasaPartenza + " " + CasaArrivo;
        }
        public Mossa(Coordinata casaPartenza, Coordinata casaArrivo){
            this.CasaPartenza = casaPartenza;
            this.CasaArrivo = casaArrivo;
        }
    }
}