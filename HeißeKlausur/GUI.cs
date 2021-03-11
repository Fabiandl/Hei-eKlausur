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
        }


    }
}