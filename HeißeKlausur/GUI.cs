using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HeißeKlausur
{
    public partial class GUI : Form
    {
        private LogikKlausur klausur0;
        private LogikKlausur klausur1;
        private LogikKlausur klausur2;
        
        public GUI()
        {
            InitializeComponent();
            klausur0 = new LogikKlausur("Numerik");
            klausur1 = new LogikKlausur("C#");
            klausur2 = new LogikKlausur("Datenbanken");
            
            this.labelKlausur0.Text = klausur0.name;
            this.labelKlausur1.Text = klausur1.name;
            this.labelKlausur2.Text = klausur2.name;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string labelText = label1.Text;
            bool isButtonEnabled = buttonNumerik.Enabled;
            klausur0.bearbeiteAufgabe(ref labelText, ref isButtonEnabled);

            label1.Text = labelText;
            buttonNumerik.Enabled = isButtonEnabled;
        }

        private void labelKlausur0_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}