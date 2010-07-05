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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learn));
            this.VocabularyListBox = new System.Windows.Forms.ListBox();
            this.axQuest3DCtrl41 = new AxQuest3DActiveX4Lib.AxQuest3DCtrl4();
            this.LearningTitle = new System.Windows.Forms.Label();
            this.LearnedWord = new System.Windows.Forms.Label();
            this.LearningPicBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VocabularyListBox
            // 
            this.VocabularyListBox.FormattingEnabled = true;
            this.VocabularyListBox.Location = new System.Drawing.Point(34, 137);
            this.VocabularyListBox.Name = "VocabularyListBox";
            this.VocabularyListBox.Size = new System.Drawing.Size(148, 316);
            this.VocabularyListBox.TabIndex = 4;
            this.VocabularyListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Double_Clicked_Item);
            this.VocabularyListBox.SelectedIndexChanged += new System.EventHandler(this.VocabularyListBox_SelectedIndexChanged);
            // 
            // axQuest3DCtrl41
            // 
            this.axQuest3DCtrl41.Enabled = true;
            this.axQuest3DCtrl41.Location = new System.Drawing.Point(523, 137);
            this.axQuest3DCtrl41.Name = "axQuest3DCtrl41";
            this.axQuest3DCtrl41.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axQuest3DCtrl41.OcxState")));
            this.axQuest3DCtrl41.Size = new System.Drawing.Size(280, 317);
            this.axQuest3DCtrl41.TabIndex = 6;
            // 
            // LearningTitle
            // 
            this.LearningTitle.AutoSize = true;
            this.LearningTitle.BackColor = System.Drawing.Color.Transparent;
            this.LearningTitle.Font = new System.Drawing.Font("Jokerman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningTitle.Location = new System.Drawing.Point(150, 22);
            this.LearningTitle.Name = "LearningTitle";
            this.LearningTitle.Size = new System.Drawing.Size(549, 55);
            this.LearningTitle.TabIndex = 7;
            this.LearningTitle.Text = "Let\'s learn the Sign language";
            // 
            // LearnedWord
            // 
            this.LearnedWord.AutoSize = true;
            this.LearnedWord.BackColor = System.Drawing.Color.Transparent;
            this.LearnedWord.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearnedWord.Location = new System.Drawing.Point(415, 483);
            this.LearnedWord.Name = "LearnedWord";
            this.LearnedWord.Size = new System.Drawing.Size(0, 77);
            this.LearnedWord.TabIndex = 8;
            // 
            // LearningPicBox
            // 
            this.LearningPicBox.BackColor = System.Drawing.Color.Transparent;
            this.LearningPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearningPicBox.Location = new System.Drawing.Point(215, 137);
            this.LearningPicBox.Name = "LearningPicBox";
            this.LearningPicBox.Size = new System.Drawing.Size(277, 317);
            this.LearningPicBox.TabIndex = 5;
            this.LearningPicBox.TabStop = false;
            this.LearningPicBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(768, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "<<Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIGNlator.Properties.Resources.LearnBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LearnedWord);
            this.Controls.Add(this.LearningTitle);
            this.Controls.Add(this.axQuest3DCtrl41);
            this.Controls.Add(this.LearningPicBox);
            this.Controls.Add(this.VocabularyListBox);
            this.DoubleBuffered = true;
            this.Name = "Learn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn";
            this.Load += new System.EventHandler(this.Learn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VocabularyListBox;
        private System.Windows.Forms.PictureBox LearningPicBox;
        private AxQuest3DActiveX4Lib.AxQuest3DCtrl4 axQuest3DCtrl41;
        private System.Windows.Forms.Label LearningTitle;
        private System.Windows.Forms.Label LearnedWord;
        private System.Windows.Forms.Button button1;
    }
}