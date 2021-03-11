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
            
            InitializeUi();
        }

        private void InitializeUi()
        {
            this.labelKlausur0.Text = klausur0.name;
            this.labelKlausur1.Text = klausur1.name;
            this.labelKlausur2.Text = klausur2.name;

            punkte1.Text = "0";
            punkte2.Text = "0";
            punkte3.Text = "0";
            labelSumPunkte.Text = "0";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string labelText = punkte1.Text;
            bool isButtonEnabled = buttonNumerik.Enabled;
            klausur0.bearbeiteAufgabe(ref labelText, ref isButtonEnabled);

            punkte1.Text = labelText;
            buttonNumerik.Enabled = isButtonEnabled;
            UpdateAllPoints();
        }

        private void UpdateAllPoints()
        {
            var points01 = int.Parse(punkte1.Text);
            var points02 = int.Parse(punkte2.Text);
            var points03 = int.Parse(punkte3.Text);

            var allPoints = points01 + points02 + points03;
            labelSumPunkte.Text = allPoints.ToString();
        }


    }
}