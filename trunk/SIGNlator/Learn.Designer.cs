namespace SIGNlator
{
    partial class Learn
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
            this.TranslateTTS = new System.Windows.Forms.Button();
            this.Record_Story = new System.Windows.Forms.Button();
            this.Show_Sign = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TranslateTTS
            // 
            this.TranslateTTS.Location = new System.Drawing.Point(277, 78);
            this.TranslateTTS.Name = "TranslateTTS";
            this.TranslateTTS.Size = new System.Drawing.Size(123, 23);
            this.TranslateTTS.TabIndex = 0;
            this.TranslateTTS.Text = "Translate Text";
            this.TranslateTTS.UseVisualStyleBackColor = true;
            this.TranslateTTS.Click += new System.EventHandler(this.TranslateTTS_Click);
            // 
            // Record_Story
            // 
            this.Record_Story.Location = new System.Drawing.Point(305, 153);
            this.Record_Story.Name = "Record_Story";
            this.Record_Story.Size = new System.Drawing.Size(75, 23);
            this.Record_Story.TabIndex = 1;
            this.Record_Story.Text = "Record";
            this.Record_Story.UseVisualStyleBackColor = true;
            this.Record_Story.Click += new System.EventHandler(this.Record_Story_Click);
            // 
            // Show_Sign
            // 
            this.Show_Sign.Location = new System.Drawing.Point(256, 216);
            this.Show_Sign.Name = "Show_Sign";
            this.Show_Sign.Size = new System.Drawing.Size(109, 23);
            this.Show_Sign.TabIndex = 2;
            this.Show_Sign.Text = "Translate Speech";
            this.Show_Sign.UseVisualStyleBackColor = true;
            this.Show_Sign.Click += new System.EventHandler(this.Show_Sign_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(64, 78);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(147, 20);
            this.InputText.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(34, 135);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(192, 173);
            this.listBox.TabIndex = 4;
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 332);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.Show_Sign);
            this.Controls.Add(this.Record_Story);
            this.Controls.Add(this.TranslateTTS);
            this.Name = "Learn";
            this.Text = "Learn";
            this.Load += new System.EventHandler(this.Learn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TranslateTTS;
        private System.Windows.Forms.Button Record_Story;
        private System.Windows.Forms.Button Show_Sign;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.ListBox listBox;
    }
}