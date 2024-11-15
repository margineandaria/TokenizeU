using System;
using System.Collections.Generic;

namespace Tokenizeu
{
    public class Nota
    {
        public double Valoare { get; set; }
        public int Incercare { get; set; }

        public Nota(double valoare, int incercare)
        {
            Valoare = valoare;
            Incercare = incercare;
        }

        public double CalculeazaPunctaj()
        {
            double pondere = Incercare switch
            {
                1 => 2.5,  
                2 => 1.5,  
                3 => 0.7,  
                _ => 0.5   
            };

            return Valoare * pondere;
        }
    }

    public class NoteSesiune
    {
        public List<Nota> ListeNote { get; set; }
        public int NumărIncercari { get; set; }

        public NoteSesiune(List<Nota> listeNote, int numarIncercari)
        {
            ListeNote = listeNote;
            NumărIncercari = numarIncercari;
        }

        // Modificăm metoda pentru a calcula punctajul total ținând cont de ponderea fiecărei note
        public double CalculeazaPunctajTotalNote()
        {
            if (ListeNote.Count == 0) return 0;

            double punctajTotal = 0;
            foreach (var nota in ListeNote)
            {
                punctajTotal += nota.CalculeazaPunctaj();
            }

            return punctajTotal;
        }

        public void AfiseazaNote()
        {
            foreach (var nota in ListeNote)
            {
                Console.WriteLine($"Nota: {nota.Valoare} (Încercare: {nota.Incercare})");
            }
        }
    }
}
