namespace SIGNlator
{
    partial class Boundary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boundary));
            this.Help_Ico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Help_Ico)).BeginInit();
            this.SuspendLayout();
            // 
            // Help_Ico
            // 
            this.Help_Ico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Help_Ico.BackgroundImage")));
            this.Help_Ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help_Ico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help_Ico.Location = new System.Drawing.Point(8, 10);
            this.Help_Ico.Name = "Help_Ico";
            this.Help_Ico.Size = new System.Drawing.Size(35, 32);
            this.Help_Ico.TabIndex = 0;
            this.Help_Ico.TabStop = false;
            this.Help_Ico.Click += new System.EventHandler(this.Help_Ico_Click);
            // 
            // Boundary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 403);
            this.Controls.Add(this.Help_Ico);
            this.Name = "Boundary";
            this.Text = "Boundary";
            ((System.ComponentModel.ISupportInitialize)(this.Help_Ico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Help_Ico;
    }
}