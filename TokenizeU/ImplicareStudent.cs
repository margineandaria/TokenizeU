using System;

namespace Tokenizeu
{
    public class ImplicareStudent
    {
        public int OreVoluntariatUniversitate { get; set; }
        public int OreVoluntariatSocietate { get; set; }

        // Constructorul pentru initializarea orelor de voluntariat
        public ImplicareStudent(int oreVoluntariatUni, int oreVoluntariatSoc)
        {
            OreVoluntariatUniversitate = oreVoluntariatUni;
            OreVoluntariatSocietate = oreVoluntariatSoc;
        }

        // Metoda pentru calcularea punctajului pe baza orelor de voluntariat
        public double CalculeazaPunctajVoluntariat()
        {
            // Calculăm punctajul pentru voluntariatul la universitate (1.5 puncte per oră)
            double punctajUniversitate = OreVoluntariatUniversitate * 1.5;

            // Calculăm punctajul pentru voluntariatul în societate (1 punct per oră)
            double punctajSocietate = OreVoluntariatSocietate * 1;

            // Totalizăm punctajele
            double punctajTotal = punctajUniversitate + punctajSocietate;

            return punctajTotal;
        }
    }
}
