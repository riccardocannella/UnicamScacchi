using System;
using System.Collections.Generic;
using Scacchi.Servizi;

namespace Scacchi.Modello
{
    public class BloccoNote : IBloccoNote
    {
        public IEnumerable<string> LeggiMosse()
        {

            return null;
        }

        public async void ScriviMossaAsync(Coordinata casaPartenza, Coordinata casaArrivo)
        {
            MioDbContext db = new MioDbContext();
            Mossa mossas = new Mossa(casaPartenza, casaArrivo);
            db.mosse.Add(mossas);
            await db.SaveChangesAsync();
            db.Dispose();
        }
    }
}