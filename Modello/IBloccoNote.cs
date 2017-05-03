using System.Collections.Generic;

namespace Scacchi.Modello
{
    public interface IBloccoNote
    {
        void ScriviMossaAsync(Coordinata casaPartenza, Coordinata casaArrivo);
        IEnumerable<string> LeggiMosse();
    }
}