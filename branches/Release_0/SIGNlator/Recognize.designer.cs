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
            this.Save_Story = new System.Windows.Forms.Button();
            this.PlaySaved = new System.Windows.Forms.Button();
            this.Saved_Stories = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.TextBox();
            this.StoryNameCBox = new System.Windows.Forms.ComboBox();
            this.Record_Story = new System.Windows.Forms.Button();
            this.SaveStoryName = new System.Windows.Forms.TextBox();
            this.TextToSpeech = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Adjust = new System.Windows.Forms.Button();
            this.Show_Sign = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PlaySavedStories = new System.Windows.Forms.Button();
            this.axQuest3DCtrl41 = new AxQuest3DActiveX4Lib.AxQuest3DCtrl4();
            this.TextToSpeech.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).BeginInit();
            this.SuspendLayout();
            // 
            // TranslateTTS
            // 
            this.TranslateTTS.Location = new System.Drawing.Point(137, 28);
            this.TranslateTTS.Name = "TranslateTTS";
            this.TranslateTTS.Size = new System.Drawing.Size(158, 23);
            this.TranslateTTS.TabIndex = 0;
            this.TranslateTTS.Text = "Translate Text";
            this.TranslateTTS.UseVisualStyleBackColor = true;
            this.TranslateTTS.Click += new System.EventHandler(this.TranslateTTS_Click);
            // 
            // Save_Story
            // 
            this.Save_Story.Location = new System.Drawing.Point(163, 52);
            this.Save_Story.Name = "Save_Story";
            this.Save_Story.Size = new System.Drawing.Size(144, 23);
            this.Save_Story.TabIndex = 2;
            this.Save_Story.Text = "Save Story";
            this.Save_Story.UseVisualStyleBackColor = true;
            this.Save_Story.Click += new System.EventHandler(this.Save_Story_Click);
            // 
            // PlaySaved
            // 
            this.PlaySaved.Location = new System.Drawing.Point(198, 390);
            this.PlaySaved.Name = "PlaySaved";
            this.PlaySaved.Size = new System.Drawing.Size(75, 23);
            this.PlaySaved.TabIndex = 3;
            this.PlaySaved.Text = "Play";
            this.PlaySaved.UseVisualStyleBackColor = true;
            this.PlaySaved.Click += new System.EventHandler(this.PlaySaved_Click);
            // 
            // Saved_Stories
            // 
            this.Saved_Stories.Location = new System.Drawing.Point(6, 29);
            this.Saved_Stories.Name = "Saved_Stories";
            this.Saved_Stories.Size = new System.Drawing.Size(113, 23);
            this.Saved_Stories.TabIndex = 4;
            this.Saved_Stories.Text = "Load saved stories";
            this.Saved_Stories.UseVisualStyleBackColor = true;
            this.Saved_Stories.Click += new System.EventHandler(this.Saved_Stories_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(6, 31);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(100, 20);
            this.InputText.TabIndex = 5;
            // 
            // StoryNameCBox
            // 
            this.StoryNameCBox.FormattingEnabled = true;
            this.StoryNameCBox.Location = new System.Drawing.Point(163, 31);
            this.StoryNameCBox.Name = "StoryNameCBox";
            this.StoryNameCBox.Size = new System.Drawing.Size(144, 21);
            this.StoryNameCBox.TabIndex = 6;
            // 
            // Record_Story
            // 
            this.Record_Story.Location = new System.Drawing.Point(6, 71);
            this.Record_Story.Name = "Record_Story";
            this.Record_Story.Size = new System.Drawing.Size(101, 23);
            this.Record_Story.TabIndex = 7;
            this.Record_Story.Text = "Start Recording";
            this.Record_Story.UseVisualStyleBackColor = true;
            this.Record_Story.Click += new System.EventHandler(this.Record_Story_Click);
            // 
            // SaveStoryName
            // 
            this.SaveStoryName.Location = new System.Drawing.Point(6, 55);
            this.SaveStoryName.Name = "SaveStoryName";
            this.SaveStoryName.Size = new System.Drawing.Size(100, 20);
            this.SaveStoryName.TabIndex = 9;
            // 
            // TextToSpeech
            // 
            this.TextToSpeech.Controls.Add(this.InputText);
            this.TextToSpeech.Controls.Add(this.TranslateTTS);
            this.TextToSpeech.Location = new System.Drawing.Point(12, 33);
            this.TextToSpeech.Name = "TextToSpeech";
            this.TextToSpeech.Size = new System.Drawing.Size(330, 84);
            this.TextToSpeech.TabIndex = 10;
            this.TextToSpeech.TabStop = false;
            this.TextToSpeech.Text = "Text to sign:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Adjust);
            this.groupBox1.Controls.Add(this.Show_Sign);
            this.groupBox1.Controls.Add(this.Record_Story);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 115);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speech to sign";
            // 
            // Adjust
            // 
            this.Adjust.Location = new System.Drawing.Point(163, 20);
            this.Adjust.Name = "Adjust";
            this.Adjust.Size = new System.Drawing.Size(144, 23);
            this.Adjust.TabIndex = 8;
            this.Adjust.Text = "Adjust Sound";
            this.Adjust.UseVisualStyleBackColor = true;
            this.Adjust.Click += new System.EventHandler(this.Adjust_Click);
            // 
            // Show_Sign
            // 
            this.Show_Sign.Location = new System.Drawing.Point(163, 71);
            this.Show_Sign.Name = "Show_Sign";
            this.Show_Sign.Size = new System.Drawing.Size(144, 23);
            this.Show_Sign.TabIndex = 1;
            this.Show_Sign.Text = "Stop and translate>>";
            this.Show_Sign.UseVisualStyleBackColor = true;
            this.Show_Sign.Click += new System.EventHandler(this.Show_Sign_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Save_Story);
            this.groupBox2.Controls.Add(this.SaveStoryName);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 91);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save story:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter story name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PlaySavedStories);
            this.groupBox3.Controls.Add(this.Saved_Stories);
            this.groupBox3.Controls.Add(this.StoryNameCBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 107);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Play saved stories";
            // 
            // PlaySavedStories
            // 
            this.PlaySavedStories.Location = new System.Drawing.Point(163, 75);
            this.PlaySavedStories.Name = "PlaySavedStories";
            this.PlaySavedStories.Size = new System.Drawing.Size(144, 23);
            this.PlaySavedStories.TabIndex = 7;
            this.PlaySavedStories.Text = "Play";
            this.PlaySavedStories.UseVisualStyleBackColor = true;
            this.PlaySavedStories.Click += new System.EventHandler(this.PlaySavedStories_Click);
            // 
            // axQuest3DCtrl41
            // 
            this.axQuest3DCtrl41.Enabled = true;
            this.axQuest3DCtrl41.Location = new System.Drawing.Point(396, 33);
            this.axQuest3DCtrl41.Name = "axQuest3DCtrl41";
            this.axQuest3DCtrl41.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axQuest3DCtrl41.OcxState")));
            this.axQuest3DCtrl41.Size = new System.Drawing.Size(255, 441);
            this.axQuest3DCtrl41.TabIndex = 14;
            // 
            // Recognize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 502);
            this.Controls.Add(this.axQuest3DCtrl41);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextToSpeech);
            this.Controls.Add(this.PlaySaved);
            this.Name = "Recognize";
            this.Text = "asd";
            this.Load += new System.EventHandler(this.Recognize_Load);
            this.TextToSpeech.ResumeLayout(false);
            this.TextToSpeech.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TranslateTTS;
        private System.Windows.Forms.Button Save_Story;
        private System.Windows.Forms.Button PlaySaved;
        private System.Windows.Forms.Button Saved_Stories;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.ComboBox StoryNameCBox;
        private System.Windows.Forms.Button Record_Story;
     //   private AxQuest3DActiveX4Lib.AxQuest3DCtrl4 axQuest3DCtrl41;
        private System.Windows.Forms.TextBox SaveStoryName;
        private System.Windows.Forms.GroupBox TextToSpeech;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PlaySavedStories;
        private System.Windows.Forms.Button Show_Sign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adjust;
        private AxQuest3DActiveX4Lib.AxQuest3DCtrl4 axQuest3DCtrl41;
      //////  private AxQuest3DActiveX4Lib.AxQuest3DCtrl4 axQuest3DCtrl41;
    }
}