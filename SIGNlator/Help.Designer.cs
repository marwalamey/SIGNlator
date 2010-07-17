namespace SIGNlator
{
    partial class Help
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
            this.Help_Menu = new System.Windows.Forms.ListBox();
            this.Help_pb = new System.Windows.Forms.PictureBox();
            this.HowTo = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Help_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Help_Menu
            // 
            this.Help_Menu.FormattingEnabled = true;
            this.Help_Menu.Items.AddRange(new object[] {
            "Begin SIGNlator",
            "Narrate and translate",
            "Save a story",
            "Play a saved story",
            "Delete a saved story",
            "Learn a new word"});
            this.Help_Menu.Location = new System.Drawing.Point(12, 85);
            this.Help_Menu.Name = "Help_Menu";
            this.Help_Menu.Size = new System.Drawing.Size(120, 602);
            this.Help_Menu.TabIndex = 0;
           
            this.Help_Menu.DoubleClick += new System.EventHandler(this.Help_Menu_DoubleClick);
            // 
            // Help_pb
            // 
            this.Help_pb.Location = new System.Drawing.Point(148, 87);
            this.Help_pb.Name = "Help_pb";
            this.Help_pb.Size = new System.Drawing.Size(788, 610);
            this.Help_pb.TabIndex = 1;
            this.Help_pb.TabStop = false;
            // 
            // HowTo
            // 
            this.HowTo.AutoSize = true;
            this.HowTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HowTo.Location = new System.Drawing.Point(12, 69);
            this.HowTo.Name = "HowTo";
            this.HowTo.Size = new System.Drawing.Size(45, 13);
            this.HowTo.TabIndex = 2;
            this.HowTo.Text = "How to:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(343, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(382, 47);
            this.Title.TabIndex = 3;
            this.Title.Text = "How to use SIGNlator!!";
            
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(948, 709);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.HowTo);
            this.Controls.Add(this.Help_pb);
            this.Controls.Add(this.Help_Menu);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
           
            ((System.ComponentModel.ISupportInitialize)(this.Help_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Help_Menu;
        private System.Windows.Forms.PictureBox Help_pb;
        private System.Windows.Forms.Label HowTo;
        private System.Windows.Forms.Label Title;

    }
}