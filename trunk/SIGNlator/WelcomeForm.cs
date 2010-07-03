using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIGNlator
{
    public partial class WelcomeForm : Boundary
    {
        int language;

        public WelcomeForm()
        {
            InitializeComponent();
        }

      

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WelcomeForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load_1);
            this.ResumeLayout(false);

        }

        private void WelcomeForm_Load_1(object sender, EventArgs e)
        {

        }
        private void Choose_Language(int languageNo)
        { }
    }
}
