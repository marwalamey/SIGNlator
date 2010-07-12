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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recognize));
            this.TranslateTTS = new System.Windows.Forms.Button();
            this.SaveStoryName = new System.Windows.Forms.TextBox();
            this.TextToSpeech = new System.Windows.Forms.GroupBox();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.axQuest3DCtrl41 = new AxQuest3DActiveX4Lib.AxQuest3DCtrl4();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StoryNameCBox = new System.Windows.Forms.ComboBox();
            this.pb_AdjustMic = new System.Windows.Forms.PictureBox();
            this.pb_PlaySaved = new System.Windows.Forms.PictureBox();
            this.pb_Save = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ToolTip_Save = new System.Windows.Forms.ToolTip(this.components);
            this.Play_Saved_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Adjust_Mic_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Recognize_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Delete_Story = new System.Windows.Forms.PictureBox();
            this.Delete_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TextToSpeech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AdjustMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlaySaved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Story)).BeginInit();
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
            this.SaveStoryName.Location = new System.Drawing.Point(427, 558);
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
            this.InputText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InputText.Location = new System.Drawing.Point(6, 30);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(222, 327);
            this.InputText.TabIndex = 6;
            this.InputText.Text = "";
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(327, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter story name:";
            // 
            // axQuest3DCtrl41
            // 
            this.axQuest3DCtrl41.Enabled = true;
            this.axQuest3DCtrl41.Location = new System.Drawing.Point(389, 284);
            this.axQuest3DCtrl41.Name = "axQuest3DCtrl41";
            this.axQuest3DCtrl41.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axQuest3DCtrl41.OcxState")));
            this.axQuest3DCtrl41.Size = new System.Drawing.Size(442, 246);
            this.axQuest3DCtrl41.TabIndex = 14;
            this.axQuest3DCtrl41.OnEvent += new AxQuest3DActiveX4Lib._IQuest3DCtrl4Events_OnEventEventHandler(this.axQuest3DCtrl41_OnEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SIGNlator.Properties.Resources.RecOff1_copy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(588, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 39);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.Recognize_ToolTip.SetToolTip(this.pictureBox1, "Press here then narrate your story\r\nthen press again to see the transaltion");
            this.pictureBox1.MouseLeave += new System.EventHandler(this.RecBtn_Leave);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.RecBtn_hover);
            // 
            // StoryNameCBox
            // 
            this.StoryNameCBox.FormattingEnabled = true;
            this.StoryNameCBox.Location = new System.Drawing.Point(660, 559);
            this.StoryNameCBox.Name = "StoryNameCBox";
            this.StoryNameCBox.Size = new System.Drawing.Size(144, 21);
            this.StoryNameCBox.TabIndex = 6;
            // 
            // pb_AdjustMic
            // 
            this.pb_AdjustMic.BackColor = System.Drawing.Color.Transparent;
            this.pb_AdjustMic.BackgroundImage = global::SIGNlator.Properties.Resources.RecOff1_copy;
            this.pb_AdjustMic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_AdjustMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_AdjustMic.Location = new System.Drawing.Point(316, 426);
            this.pb_AdjustMic.Name = "pb_AdjustMic";
            this.pb_AdjustMic.Size = new System.Drawing.Size(50, 45);
            this.pb_AdjustMic.TabIndex = 16;
            this.pb_AdjustMic.TabStop = false;
            this.Adjust_Mic_Tooltip.SetToolTip(this.pb_AdjustMic, "Adjust your mic parameters");
            this.pb_AdjustMic.MouseLeave += new System.EventHandler(this.Adjust_leave);
            this.pb_AdjustMic.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.pb_AdjustMic.MouseHover += new System.EventHandler(this.Adjust_hover);
            // 
            // pb_PlaySaved
            // 
            this.pb_PlaySaved.BackColor = System.Drawing.Color.Transparent;
            this.pb_PlaySaved.BackgroundImage = global::SIGNlator.Properties.Resources.RecOff1_copy;
            this.pb_PlaySaved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_PlaySaved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_PlaySaved.Location = new System.Drawing.Point(316, 324);
            this.pb_PlaySaved.Name = "pb_PlaySaved";
            this.pb_PlaySaved.Size = new System.Drawing.Size(50, 45);
            this.pb_PlaySaved.TabIndex = 17;
            this.pb_PlaySaved.TabStop = false;
            this.ToolTip_Save.SetToolTip(this.pb_PlaySaved, "Save the last recognized story");
            this.pb_PlaySaved.MouseLeave += new System.EventHandler(this.PlayBtn_Leave);
            this.pb_PlaySaved.Click += new System.EventHandler(this.pictureBox3_Click_1);
            this.pb_PlaySaved.MouseHover += new System.EventHandler(this.PlayBtn_Hover);
            // 
            // pb_Save
            // 
            this.pb_Save.BackColor = System.Drawing.Color.Transparent;
            this.pb_Save.BackgroundImage = global::SIGNlator.Properties.Resources.RecOff1_copy;
            this.pb_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Save.Location = new System.Drawing.Point(316, 375);
            this.pb_Save.Name = "pb_Save";
            this.pb_Save.Size = new System.Drawing.Size(50, 45);
            this.pb_Save.TabIndex = 18;
            this.pb_Save.TabStop = false;
            this.Play_Saved_ToolTip.SetToolTip(this.pb_Save, "Play selected saved story");
            this.pb_Save.MouseLeave += new System.EventHandler(this.Savebtn_Leave);
            this.pb_Save.Click += new System.EventHandler(this.pictureBox4_Click_1);
            this.pb_Save.MouseHover += new System.EventHandler(this.Savebtn_Hover);
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
            this.label3.Location = new System.Drawing.Point(581, 562);
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
            // ToolTip_Save
            // 
            this.ToolTip_Save.AutomaticDelay = 0;
            this.ToolTip_Save.AutoPopDelay = 0;
            this.ToolTip_Save.InitialDelay = 0;
            this.ToolTip_Save.IsBalloon = true;
            this.ToolTip_Save.ReshowDelay = 0;
            this.ToolTip_Save.Tag = "";
            this.ToolTip_Save.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip_Save_Popup);
            // 
            // Play_Saved_ToolTip
            // 
            this.Play_Saved_ToolTip.AutomaticDelay = 0;
            this.Play_Saved_ToolTip.AutoPopDelay = 0;
            this.Play_Saved_ToolTip.InitialDelay = 0;
            this.Play_Saved_ToolTip.IsBalloon = true;
            this.Play_Saved_ToolTip.ReshowDelay = 0;
            this.Play_Saved_ToolTip.Tag = "";
            // 
            // Adjust_Mic_Tooltip
            // 
            this.Adjust_Mic_Tooltip.AutomaticDelay = 0;
            this.Adjust_Mic_Tooltip.AutoPopDelay = 0;
            this.Adjust_Mic_Tooltip.InitialDelay = 0;
            this.Adjust_Mic_Tooltip.IsBalloon = true;
            this.Adjust_Mic_Tooltip.ReshowDelay = 0;
            this.Adjust_Mic_Tooltip.Tag = "";
            // 
            // Recognize_ToolTip
            // 
            this.Recognize_ToolTip.AutomaticDelay = 0;
            this.Recognize_ToolTip.AutoPopDelay = 0;
            this.Recognize_ToolTip.InitialDelay = 0;
            this.Recognize_ToolTip.IsBalloon = true;
            this.Recognize_ToolTip.ReshowDelay = 0;
            this.Recognize_ToolTip.Tag = "";
            // 
            // Delete_Story
            // 
            this.Delete_Story.BackColor = System.Drawing.Color.Transparent;
            this.Delete_Story.BackgroundImage = global::SIGNlator.Properties.Resources.DeleteRed;
            this.Delete_Story.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_Story.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Story.Location = new System.Drawing.Point(810, 556);
            this.Delete_Story.Name = "Delete_Story";
            this.Delete_Story.Size = new System.Drawing.Size(36, 30);
            this.Delete_Story.TabIndex = 23;
            this.Delete_Story.TabStop = false;
            this.Delete_ToolTip.SetToolTip(this.Delete_Story, "Delete the saved story");
            this.Delete_Story.MouseLeave += new System.EventHandler(this.Delete_Leave);
            this.Delete_Story.Click += new System.EventHandler(this.Delete_Story_Click);
            this.Delete_Story.MouseHover += new System.EventHandler(this.Delete_Hover);
            // 
            // Delete_ToolTip
            // 
            this.Delete_ToolTip.AutomaticDelay = 0;
            this.Delete_ToolTip.AutoPopDelay = 0;
            this.Delete_ToolTip.InitialDelay = 0;
            this.Delete_ToolTip.IsBalloon = true;
            this.Delete_ToolTip.ReshowDelay = 0;
            this.Delete_ToolTip.Tag = "";
            // 
            // Recognize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIGNlator.Properties.Resources.Picture7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 705);
            this.Controls.Add(this.Delete_Story);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_Save);
            this.Controls.Add(this.pb_PlaySaved);
            this.Controls.Add(this.pb_AdjustMic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axQuest3DCtrl41);
            this.Controls.Add(this.SaveStoryName);
            this.Controls.Add(this.StoryNameCBox);
            this.Controls.Add(this.TextToSpeech);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "Recognize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translate a story";
            this.Load += new System.EventHandler(this.Recognize_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recognize_FormClosed);
            this.TextToSpeech.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AdjustMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlaySaved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Story)).EndInit();
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
        private System.Windows.Forms.PictureBox pb_AdjustMic;
        private System.Windows.Forms.PictureBox pb_PlaySaved;
        private System.Windows.Forms.PictureBox pb_Save;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip ToolTip_Save;
        private System.Windows.Forms.ToolTip Play_Saved_ToolTip;
        private System.Windows.Forms.ToolTip Adjust_Mic_Tooltip;
        private System.Windows.Forms.ToolTip Recognize_ToolTip;
        private System.Windows.Forms.PictureBox Delete_Story;
        private System.Windows.Forms.ToolTip Delete_ToolTip;
      //////  private AxQuest3DActiveX4Lib.AxQuest3DCtrl4 axQuest3DCtrl41;
    }
}