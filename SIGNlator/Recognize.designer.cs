namespace SIGNlator
{
    partial class Recognize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recognize));
            this.TranslateTTS = new System.Windows.Forms.Button();
            this.SaveStoryName = new System.Windows.Forms.TextBox();
            this.TextToSpeech = new System.Windows.Forms.GroupBox();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.axQuest3DCtrl41 = new AxQuest3DActiveX4Lib.AxQuest3DCtrl4();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StoryNameCBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextToSpeech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TranslateTTS
            // 
            this.TranslateTTS.Location = new System.Drawing.Point(48, 376);
            this.TranslateTTS.Name = "TranslateTTS";
            this.TranslateTTS.Size = new System.Drawing.Size(158, 23);
            this.TranslateTTS.TabIndex = 0;
            this.TranslateTTS.Text = "Translate Text";
            this.TranslateTTS.UseVisualStyleBackColor = true;
            this.TranslateTTS.Click += new System.EventHandler(this.TranslateTTS_Click);
            // 
            // SaveStoryName
            // 
            this.SaveStoryName.Location = new System.Drawing.Point(461, 542);
            this.SaveStoryName.Name = "SaveStoryName";
            this.SaveStoryName.Size = new System.Drawing.Size(103, 20);
            this.SaveStoryName.TabIndex = 9;
            // 
            // TextToSpeech
            // 
            this.TextToSpeech.BackColor = System.Drawing.Color.Transparent;
            this.TextToSpeech.Controls.Add(this.InputText);
            this.TextToSpeech.Controls.Add(this.TranslateTTS);
            this.TextToSpeech.Location = new System.Drawing.Point(12, 201);
            this.TextToSpeech.Name = "TextToSpeech";
            this.TextToSpeech.Size = new System.Drawing.Size(251, 405);
            this.TextToSpeech.TabIndex = 10;
            this.TextToSpeech.TabStop = false;
            this.TextToSpeech.Text = "Text to sign:";
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(6, 30);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(222, 327);
            this.InputText.TabIndex = 6;
            this.InputText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(361, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter story name:";
            // 
            // axQuest3DCtrl41
            // 
            this.axQuest3DCtrl41.Enabled = true;
            this.axQuest3DCtrl41.Location = new System.Drawing.Point(378, 271);
            this.axQuest3DCtrl41.Name = "axQuest3DCtrl41";
            this.axQuest3DCtrl41.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axQuest3DCtrl41.OcxState")));
            this.axQuest3DCtrl41.Size = new System.Drawing.Size(440, 243);
            this.axQuest3DCtrl41.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SIGNlator.Properties.Resources.RecOff1_copy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(565, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 39);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.RecBtn_Leave);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.RecBtn_hover);
            // 
            // StoryNameCBox
            // 
            this.StoryNameCBox.FormattingEnabled = true;
            this.StoryNameCBox.Location = new System.Drawing.Point(694, 542);
            this.StoryNameCBox.Name = "StoryNameCBox";
            this.StoryNameCBox.Size = new System.Drawing.Size(144, 21);
            this.StoryNameCBox.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SIGNlator.Properties.Resources.VistaPlayStopPauseIconsPreview1_copy;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(299, 425);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.Adjustbtn_Leave);
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.pictureBox2.MouseHover += new System.EventHandler(this.Adjustbtn_Hover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::SIGNlator.Properties.Resources.play;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(301, 311);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 50);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseLeave += new System.EventHandler(this.Playbtn_leave);
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            this.pictureBox3.MouseHover += new System.EventHandler(this.Playbtn_hover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::SIGNlator.Properties.Resources.Save;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(306, 375);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 45);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseLeave += new System.EventHandler(this.Savebtn_Leave);
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            this.pictureBox4.MouseHover += new System.EventHandler(this.Savebtn_Hover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 93);
            this.label2.TabIndex = 19;
            this.label2.Text = "SIGNlator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(615, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Saved Stories";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Learn the sign language";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recognize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIGNlator.Properties.Resources.Picture7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axQuest3DCtrl41);
            this.Controls.Add(this.SaveStoryName);
            this.Controls.Add(this.StoryNameCBox);
            this.Controls.Add(this.TextToSpeech);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "Recognize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translate a story";
            this.Load += new System.EventHandler(this.Recognize_Load);
            this.TextToSpeech.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TranslateTTS;
     //   private AxQuest3DActiveX4Lib.AxQuest3DCtrl4 axQuest3DCtrl41;
        private System.Windows.Forms.TextBox SaveStoryName;
        private System.Windows.Forms.GroupBox TextToSpeech;
        private System.Windows.Forms.Label label1;
        private AxQuest3DActiveX4Lib.AxQuest3DCtrl4 axQuest3DCtrl41;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox StoryNameCBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
      //////  private AxQuest3DActiveX4Lib.AxQuest3DCtrl4 axQuest3DCtrl41;
    }
}