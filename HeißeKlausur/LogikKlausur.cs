using System;

namespace HeißeKlausur
{
    public class LogikKlausur
    {
        private int anzahlBisDurchgefallen;
        private int punkte;
        public string name { get; }

        public LogikKlausur(string name)
        {
            Random rdm = new Random();
            this.name = name;
            this.anzahlBisDurchgefallen = rdm.Next(1, 20);
            this.punkte = 0;
        }

        public void bearbeiteAufgabe(ref string points, ref bool isButtonEnabled)
        {
            if (anzahlBisDurchgefallen == punkte)
            {
                points = punkte.ToString();
                isButtonEnabled = false;
            }
            else
            {
                punkte++;
                points = punkte.ToString();
            }
        }
        
    }
}