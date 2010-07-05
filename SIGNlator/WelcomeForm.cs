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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Begin SIGNlator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIGNlator\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Where hands say it all";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::SIGNlator.Properties.Resources.Picture3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "WelcomeForm";
            this.Text = "Welcome SIGNlator";
            this.Load += new System.EventHandler(this.WelcomeForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void WelcomeForm_Load_1(object sender, EventArgs e)
        {

        }
        private void Choose_Language(int languageNo)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            Recognize rec = new Recognize();
            rec.Show();
            this.Visible = false;
        }
    }
}
