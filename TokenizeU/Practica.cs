using System;
namespace Tokenizeu
 {
    public class Practica
    {
        public int OrePracticaVoluntara { get; set; }
        public int OrePracticaPlatita { get; set; }

        public Practica(int oreVoluntare, int orePlatite)
        {
            OrePracticaVoluntara = oreVoluntare;
            OrePracticaPlatita = orePlatite;
        }

        public double CalculeazaPunctajPractica()
        {
            double puncteVoluntare = 2 * OrePracticaVoluntara;
            double punctePlatite = 0.75 * OrePracticaPlatita;
            return puncteVoluntare + punctePlatite;
        }
    }
}
