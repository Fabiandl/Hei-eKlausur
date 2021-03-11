using System;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace HeißeKlausur
{
    public class LogikKlausur
    {
        private Timer timeToKlausur;

        public LogikKlausur()
        {
            Random rdm = new Random();
            timeToKlausur = new Timer(rdm.Next(1,5) *2000);
            timeToKlausur.Elapsed += onTimedEvent;
            timeToKlausur.Enabled = true;
        }

        public void onTimedEvent(Object source, ElapsedEventArgs args)
        {
            Console.WriteLine("Test");
        }
    }
}