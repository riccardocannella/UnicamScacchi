using System;
using Scacchi.Modello;

namespace Scacchi
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleXUnitRunner.SimpleXUnit.RunTests();
  /*          Console.ReadKey();
            IOrologio orologio = new Orologio(TimeSpan.FromSeconds(5));
            // E' consigliabile sottoscriversi non appena si ha un riferimento all'oggetto, prima di fare qualcos'altro
            //orologio.TempoScaduto += NotificaSconfitta;
            // stessa cosa ma con lambda expression. Attenzione: impossibile togliere la sottoscrizione e riutilizzare questo metodo.
            orologio.TempoScaduto += (object sender, Colore colore) =>
            {
                Console.WriteLine("Sto stampando un messaggio tramite lambda expression");
            };
            // la lambda expression può essere scritta anche senza specificare il tipo di argomenti
            EventHandler<Colore> notificaS = (sender, colore) =>
            {
                Console.WriteLine("Sto stampando un messaggio tramite lambda expression su una variabile, da cui è possibile disiscriversi");
            };
            orologio.TempoScaduto += notificaS;
            orologio.Accendi();
            orologio.Avvia();*/
            Console.ReadKey();

            //La sottoscrizione all'evento TempoScaduto è stata spostata
            //in un test in OrologioTest.cs (vedi in fondo al file, riga 180)
        }

        /*
        private static void NotificaSconfitta(object sender, Colore colore)
        {
            Console.WriteLine($"(Dal metodo): Il giocatore {colore} ha perso la partita, secondo l'orologio {sender}!");
        }
        */
    }
}
