using System;

namespace HeißeKlausur
{
    public class LogikKlausur
    {
        private int anzahlBisDurchgefallen;
        private int punkte;
        public LogikKlausur()
        {
            Random rdm = new Random();
            anzahlBisDurchgefallen = rdm.Next(1, 20);
            punkte = 0;
        }
        
        public void bearbeiteAufgabe(ref string label1Text, ref bool buttonNumerikEnabled)
        {
            throw new NotImplementedException();
        }
        
    }
}