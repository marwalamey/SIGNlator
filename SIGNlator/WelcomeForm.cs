using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

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
            this.BeginSIGNlator_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BeginSIGNlator_btn
            // 
            this.BeginSIGNlator_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BeginSIGNlator_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BeginSIGNlator_btn.Location = new System.Drawing.Point(308, 395);
            this.BeginSIGNlator_btn.Name = "BeginSIGNlator_btn";
            this.BeginSIGNlator_btn.Size = new System.Drawing.Size(201, 23);
            this.BeginSIGNlator_btn.TabIndex = 0;
            this.BeginSIGNlator_btn.Text = "Begin SIGNlator";
            this.BeginSIGNlator_btn.UseVisualStyleBackColor = true;
            this.BeginSIGNlator_btn.Click += new System.EventHandler(this.BeginSIGNlator_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIGNlator\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Where hands say it all";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::SIGNlator.Properties.Resources.Picture3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeginSIGNlator_btn);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome SIGNlator";
            this.Load += new System.EventHandler(this.WelcomeForm_Load_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WelcomeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void WelcomeForm_Load_1(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            
            //this.TopMost = true;
            
           
            
   
           
            
        }
        private void Choose_Language(int languageNo)
        { }

     

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

    

        private void BeginSIGNlator_btn_Click(object sender, EventArgs e)
        {
            Recognize rec = new Recognize(this);
            rec.Show();
            this.Visible = false;
            // t.IsBackground = false;
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            //t.Start();
            //t.IsBackground = false;
            //this.Close();
        }
    }
}
