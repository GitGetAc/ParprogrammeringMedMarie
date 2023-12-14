namespace Parprogrammering
{
    public class Bil
    {
        private int _hastighet;
        private int _økHastighetMed;
        private int _senkeHastighetMed;
        private int _totalAvstand;



        public Bil(int hastighet, int økHastighetMed, int senkeHastighetMed, int totalAvstand)
        {
            Hastighet = hastighet;
            ØkHastighetMed = økHastighetMed;
            SenkeHastighetMed = senkeHastighetMed;
            TotalAvstand = totalAvstand;
        }

        public int Hastighet { get => _hastighet; set => _hastighet = value; }
        public int ØkHastighetMed { get => _økHastighetMed; set => _økHastighetMed = value; }
        public int SenkeHastighetMed { get => _senkeHastighetMed; set => _senkeHastighetMed = value; }
        public int TotalAvstand { get => _totalAvstand; set => _totalAvstand = value; }
        
    }
}
