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
        private LogikKlausur klausurNumerik;
        private LogikKlausur klausurCSharp;
        private LogikKlausur klausurDatenbanken;

        public GUI()
        {
            InitializeComponent();
            klausurNumerik = new LogikKlausur();
            klausurCSharp = new LogikKlausur();
            klausurDatenbanken = new LogikKlausur();

            punkte1.Text = "0";
            punkte2.Text = "0";
            punkte3.Text = "0";
        }

        private void buttonNumerik_Click(object sender, EventArgs e)
        {
            string labelText = label1.Text;
            bool isButtonEnabled = buttonNumerik.Enabled;
            klausurNumerik.bearbeiteAufgabe(ref labelText, ref isButtonEnabled);

            label1.Text = labelText;
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