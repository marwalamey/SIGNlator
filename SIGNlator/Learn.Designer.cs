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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learn));
            this.VocabularyListBox = new System.Windows.Forms.ListBox();
            this.axQuest3DCtrl41 = new AxQuest3DActiveX4Lib.AxQuest3DCtrl4();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LearningTitle = new System.Windows.Forms.Label();
            this.LearnedWord = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LearningPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VocabularyListBox
            // 
            this.VocabularyListBox.FormattingEnabled = true;
            this.VocabularyListBox.Location = new System.Drawing.Point(28, 102);
            this.VocabularyListBox.Name = "VocabularyListBox";
            this.VocabularyListBox.Size = new System.Drawing.Size(117, 264);
            this.VocabularyListBox.TabIndex = 4;
            this.VocabularyListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Double_Clicked_Item);
            this.VocabularyListBox.SelectedIndexChanged += new System.EventHandler(this.VocabularyListBox_SelectedIndexChanged);
            // 
            // axQuest3DCtrl41
            // 
            this.axQuest3DCtrl41.Enabled = true;
            this.axQuest3DCtrl41.Location = new System.Drawing.Point(461, 63);
            this.axQuest3DCtrl41.Name = "axQuest3DCtrl41";
            this.axQuest3DCtrl41.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axQuest3DCtrl41.OcxState")));
            this.axQuest3DCtrl41.Size = new System.Drawing.Size(280, 303);
            this.axQuest3DCtrl41.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tvSmall.gif");
            // 
            // LearningTitle
            // 
            this.LearningTitle.AutoSize = true;
            this.LearningTitle.Font = new System.Drawing.Font("Jokerman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningTitle.Location = new System.Drawing.Point(163, 9);
            this.LearningTitle.Name = "LearningTitle";
            this.LearningTitle.Size = new System.Drawing.Size(402, 39);
            this.LearningTitle.TabIndex = 7;
            this.LearningTitle.Text = "Let\'s learn the Sign language";
            // 
            // LearnedWord
            // 
            this.LearnedWord.AutoSize = true;
            this.LearnedWord.Location = new System.Drawing.Point(422, 376);
            this.LearnedWord.Name = "LearnedWord";
            this.LearnedWord.Size = new System.Drawing.Size(0, 13);
            this.LearnedWord.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(593, 376);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 140);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // LearningPicBox
            // 
            this.LearningPicBox.BackColor = System.Drawing.Color.Transparent;
            
            this.LearningPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearningPicBox.Location = new System.Drawing.Point(186, 102);
            this.LearningPicBox.Name = "LearningPicBox";
            this.LearningPicBox.Size = new System.Drawing.Size(248, 221);
            this.LearningPicBox.TabIndex = 5;
            this.LearningPicBox.TabStop = false;
            this.LearningPicBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 512);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LearnedWord);
            this.Controls.Add(this.LearningTitle);
            this.Controls.Add(this.axQuest3DCtrl41);
            this.Controls.Add(this.LearningPicBox);
            this.Controls.Add(this.VocabularyListBox);
            this.Name = "Learn";
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LearningTitle;
        private System.Windows.Forms.Label LearnedWord;
        private System.Windows.Forms.ListView listView1;
    }
}