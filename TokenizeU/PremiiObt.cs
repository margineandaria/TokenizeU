using System;
    namespace Tokenizeu
    {
    public class PremiiObtinute
    {
        private string TipPremiu;

        public PremiiObtinute(string tipPremiu)
        {
            TipPremiu = tipPremiu;
        }
        
        public double CalculeazaPunctajPremii()
        {
            switch (TipPremiu)
            {
                case "Concurs National":
                    return 100;
                case "Premiu National":
                    return 200;
                case "Premiu International":
                    return 300;
                case "Nu a Participat":
                    return 0;
                default:
                    return 0;
            }
        }
    }

}