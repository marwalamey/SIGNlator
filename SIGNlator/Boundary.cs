using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIGNlator
{
    public partial class Boundary : Form
    {

        public int Language;
        public Core core= new Core();
        public Boundary()
        {
            InitializeComponent();
        }

        private void Help_Ico_Click(object sender, EventArgs e)
        {
            Help hlp = new Help();
            hlp.Show();
        }

    
    }
}
