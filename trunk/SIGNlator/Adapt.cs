using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIGNlator
{
    public partial class Adapt : Form
    {
        private Core core = new Core();
        public Adapt()
        {
            InitializeComponent();
        }

        private void Save_Wave_File_Click(object sender, EventArgs e)
        {
            core.Record_Speech();
        }

        private void Adaptbtn_Click(object sender, EventArgs e)
        {
            core.Run_Adaptation();
        }

        private void Adapt_Load(object sender, EventArgs e)
        {

        }

        
    }
}
