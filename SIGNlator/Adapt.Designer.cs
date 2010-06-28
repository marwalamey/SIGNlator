namespace SIGNlator
{
    partial class Adapt
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
            this.Save_Wave_File = new System.Windows.Forms.Button();
            this.Adaptbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save_Wave_File
            // 
            this.Save_Wave_File.Location = new System.Drawing.Point(280, 125);
            this.Save_Wave_File.Name = "Save_Wave_File";
            this.Save_Wave_File.Size = new System.Drawing.Size(75, 23);
            this.Save_Wave_File.TabIndex = 0;
            this.Save_Wave_File.Text = "Record";
            this.Save_Wave_File.UseVisualStyleBackColor = true;
            this.Save_Wave_File.Click += new System.EventHandler(this.Save_Wave_File_Click);
            // 
            // Adaptbtn
            // 
            this.Adaptbtn.Location = new System.Drawing.Point(135, 170);
            this.Adaptbtn.Name = "Adaptbtn";
            this.Adaptbtn.Size = new System.Drawing.Size(75, 23);
            this.Adaptbtn.TabIndex = 1;
            this.Adaptbtn.Text = "Adapt";
            this.Adaptbtn.UseVisualStyleBackColor = true;
            this.Adaptbtn.Click += new System.EventHandler(this.Adaptbtn_Click);
            // 
            // Adapt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 386);
            this.Controls.Add(this.Adaptbtn);
            this.Controls.Add(this.Save_Wave_File);
            this.Name = "Adapt";
            this.Text = "Adapt";
            this.Load += new System.EventHandler(this.Adapt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save_Wave_File;
        private System.Windows.Forms.Button Adaptbtn;
    }
}