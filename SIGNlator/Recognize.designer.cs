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
            this.pb_AdjustMic = new System.Windows.Forms.PictureBox();
            this.pb_PlaySaved = new System.Windows.Forms.PictureBox();
            this.pb_Save = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ToLearn_btn = new System.Windows.Forms.Button();
            this.ToolTip_Save = new System.Windows.Forms.ToolTip(this.components);
            this.Play_Saved_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Adjust_Mic_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Recognize_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Recognize_Pb = new System.Windows.Forms.PictureBox();
            this.Delete_Story = new System.Windows.Forms.PictureBox();
            this.Delete_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StoryNameCBox = new System.Windows.Forms.ComboBox();
            this.PlaySaved_lbl = new System.Windows.Forms.Label();
            this.Save_lbl = new System.Windows.Forms.Label();
            this.Mic_lbl = new System.Windows.Forms.Label();
            this.RecordRec_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Help_Ico)).BeginInit();
            this.TextToSpeech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AdjustMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlaySaved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recognize_Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Story)).BeginInit();
            this.SuspendLayout();
            // 
            // Help_Ico
            // 
            this.Help_Ico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Help_Ico.BackgroundImage")));
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
            this.SaveStoryName.Location = new System.Drawing.Point(467, 558);
            this.SaveStoryName.Name = "SaveStoryName";
            this.SaveStoryName.Size = new System.Drawing.Size(103, 20);
            this.SaveStoryName.TabIndex = 9;
            this.SaveStoryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaveStoryName_KeyPress);
            // 
            // TextToSpeech
            // 
            this.TextToSpeech.BackColor = System.Drawing.Color.Transparent;
            this.TextToSpeech.Controls.Add(this.InputText);
            this.TextToSpeech.Controls.Add(this.TranslateTTS);
            this.TextToSpeech.Location = new System.Drawing.Point(49, 214);
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
            this.InputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(367, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter story name:";
            // 
            // axQuest3DCtrl41
            // 
            this.axQuest3DCtrl41.Enabled = true;
            this.axQuest3DCtrl41.Location = new System.Drawing.Point(411, 289);
            this.axQuest3DCtrl41.Name = "axQuest3DCtrl41";
            this.axQuest3DCtrl41.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axQuest3DCtrl41.OcxState")));
            this.axQuest3DCtrl41.Size = new System.Drawing.Size(450, 246);
            this.axQuest3DCtrl41.TabIndex = 14;
            this.axQuest3DCtrl41.OnEvent += new AxQuest3DActiveX4Lib._IQuest3DCtrl4Events_OnEventEventHandler(this.axQuest3DCtrl41_OnEvent);
            // 
            // pb_AdjustMic
            // 
            this.pb_AdjustMic.BackColor = System.Drawing.Color.Transparent;
            this.pb_AdjustMic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_AdjustMic.BackgroundImage")));
            this.pb_AdjustMic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_AdjustMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_AdjustMic.Location = new System.Drawing.Point(343, 467);
            this.pb_AdjustMic.Name = "pb_AdjustMic";
            this.pb_AdjustMic.Size = new System.Drawing.Size(50, 45);
            this.pb_AdjustMic.TabIndex = 16;
            this.pb_AdjustMic.TabStop = false;
            this.Adjust_Mic_Tooltip.SetToolTip(this.pb_AdjustMic, "Adjust your mic parameters");
            this.pb_AdjustMic.MouseLeave += new System.EventHandler(this.Adjust_leave);
            this.pb_AdjustMic.Click += new System.EventHandler(this.pb_AdjustMic_Click);
            this.pb_AdjustMic.MouseHover += new System.EventHandler(this.Adjust_hover);
            // 
            // pb_PlaySaved
            // 
            this.pb_PlaySaved.BackColor = System.Drawing.Color.Transparent;
            this.pb_PlaySaved.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_PlaySaved.BackgroundImage")));
            this.pb_PlaySaved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_PlaySaved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_PlaySaved.Location = new System.Drawing.Point(343, 318);
            this.pb_PlaySaved.Name = "pb_PlaySaved";
            this.pb_PlaySaved.Size = new System.Drawing.Size(50, 45);
            this.pb_PlaySaved.TabIndex = 17;
            this.pb_PlaySaved.TabStop = false;
            this.Play_Saved_ToolTip.SetToolTip(this.pb_PlaySaved, "Play selected saved story");
            this.pb_PlaySaved.MouseLeave += new System.EventHandler(this.PlayBtn_Leave);
            this.pb_PlaySaved.Click += new System.EventHandler(this.pb_PlaySaved_Click);
            this.pb_PlaySaved.MouseHover += new System.EventHandler(this.PlayBtn_Hover);
            // 
            // pb_Save
            // 
            this.pb_Save.BackColor = System.Drawing.Color.Transparent;
            this.pb_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Save.BackgroundImage")));
            this.pb_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Save.Location = new System.Drawing.Point(343, 393);
            this.pb_Save.Name = "pb_Save";
            this.pb_Save.Size = new System.Drawing.Size(50, 45);
            this.pb_Save.TabIndex = 18;
            this.pb_Save.TabStop = false;
            this.ToolTip_Save.SetToolTip(this.pb_Save, "Save the last recognized story");
            this.pb_Save.MouseLeave += new System.EventHandler(this.Savebtn_Leave);
            this.pb_Save.Click += new System.EventHandler(this.pb_Save_Click);
            this.pb_Save.MouseHover += new System.EventHandler(this.Savebtn_Hover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 36);
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
            // ToLearn_btn
            // 
            this.ToLearn_btn.Location = new System.Drawing.Point(796, 22);
            this.ToLearn_btn.Name = "ToLearn_btn";
            this.ToLearn_btn.Size = new System.Drawing.Size(136, 32);
            this.ToLearn_btn.TabIndex = 21;
            this.ToLearn_btn.Text = "Learn the sign language";
            this.ToLearn_btn.UseVisualStyleBackColor = true;
            this.ToLearn_btn.Click += new System.EventHandler(this.ToLearn_btn_Click);
            // 
            // ToolTip_Save
            // 
            this.ToolTip_Save.AutomaticDelay = 0;
            this.ToolTip_Save.AutoPopDelay = 0;
            this.ToolTip_Save.InitialDelay = 0;
            this.ToolTip_Save.IsBalloon = true;
            this.ToolTip_Save.ReshowDelay = 0;
            this.ToolTip_Save.Tag = "";
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
            // Recognize_Pb
            // 
            this.Recognize_Pb.BackColor = System.Drawing.Color.Transparent;
            this.Recognize_Pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Recognize_Pb.BackgroundImage")));
            this.Recognize_Pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Recognize_Pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recognize_Pb.Location = new System.Drawing.Point(581, 222);
            this.Recognize_Pb.Name = "Recognize_Pb";
            this.Recognize_Pb.Size = new System.Drawing.Size(53, 39);
            this.Recognize_Pb.TabIndex = 15;
            this.Recognize_Pb.TabStop = false;
            this.Recognize_ToolTip.SetToolTip(this.Recognize_Pb, "Press here then narrate your story\r\nthen press again to see the transaltion");
            this.Recognize_Pb.MouseLeave += new System.EventHandler(this.RecBtn_Leave);
            this.Recognize_Pb.Click += new System.EventHandler(this.Recognize_Pb_Click);
            this.Recognize_Pb.MouseHover += new System.EventHandler(this.RecBtn_hover);
            // 
            // Delete_Story
            // 
            this.Delete_Story.BackColor = System.Drawing.Color.Transparent;
            this.Delete_Story.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Story.BackgroundImage")));
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
            // StoryNameCBox
            // 
            this.StoryNameCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoryNameCBox.FormattingEnabled = true;
            this.StoryNameCBox.Items.AddRange(new object[] {
            "Reads",
            "Updates"});
            this.StoryNameCBox.Location = new System.Drawing.Point(660, 559);
            this.StoryNameCBox.Name = "StoryNameCBox";
            this.StoryNameCBox.Size = new System.Drawing.Size(144, 21);
            this.StoryNameCBox.TabIndex = 24;
            // 
            // PlaySaved_lbl
            // 
            this.PlaySaved_lbl.AutoSize = true;
            this.PlaySaved_lbl.BackColor = System.Drawing.Color.Transparent;
            this.PlaySaved_lbl.Location = new System.Drawing.Point(352, 366);
            this.PlaySaved_lbl.Name = "PlaySaved_lbl";
            this.PlaySaved_lbl.Size = new System.Drawing.Size(27, 13);
            this.PlaySaved_lbl.TabIndex = 25;
            this.PlaySaved_lbl.Text = "Play";
            // 
            // Save_lbl
            // 
            this.Save_lbl.AutoSize = true;
            this.Save_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Save_lbl.Location = new System.Drawing.Point(352, 437);
            this.Save_lbl.Name = "Save_lbl";
            this.Save_lbl.Size = new System.Drawing.Size(31, 13);
            this.Save_lbl.TabIndex = 26;
            this.Save_lbl.Text = "Save";
            // 
            // Mic_lbl
            // 
            this.Mic_lbl.AutoSize = true;
            this.Mic_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Mic_lbl.Location = new System.Drawing.Point(342, 512);
            this.Mic_lbl.Name = "Mic_lbl";
            this.Mic_lbl.Size = new System.Drawing.Size(56, 13);
            this.Mic_lbl.TabIndex = 27;
            this.Mic_lbl.Text = "Adjust Mic";
            // 
            // RecordRec_lbl
            // 
            this.RecordRec_lbl.AutoSize = true;
            this.RecordRec_lbl.BackColor = System.Drawing.Color.Transparent;
            this.RecordRec_lbl.Location = new System.Drawing.Point(570, 263);
            this.RecordRec_lbl.Name = "RecordRec_lbl";
            this.RecordRec_lbl.Size = new System.Drawing.Size(81, 13);
            this.RecordRec_lbl.TabIndex = 28;
            this.RecordRec_lbl.Text = "Narrate a story";
            // 
            // Recognize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 705);
            this.Controls.Add(this.RecordRec_lbl);
            this.Controls.Add(this.Mic_lbl);
            this.Controls.Add(this.Save_lbl);
            this.Controls.Add(this.PlaySaved_lbl);
            this.Controls.Add(this.StoryNameCBox);
            this.Controls.Add(this.Delete_Story);
            this.Controls.Add(this.ToLearn_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_Save);
            this.Controls.Add(this.pb_PlaySaved);
            this.Controls.Add(this.pb_AdjustMic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Recognize_Pb);
            this.Controls.Add(this.axQuest3DCtrl41);
            this.Controls.Add(this.SaveStoryName);
            this.Controls.Add(this.TextToSpeech);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Recognize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translate a story";
            this.Load += new System.EventHandler(this.Recognize_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recognize_FormClosed);
            this.Controls.SetChildIndex(this.TextToSpeech, 0);
            this.Controls.SetChildIndex(this.SaveStoryName, 0);
            this.Controls.SetChildIndex(this.axQuest3DCtrl41, 0);
            this.Controls.SetChildIndex(this.Recognize_Pb, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pb_AdjustMic, 0);
            this.Controls.SetChildIndex(this.pb_PlaySaved, 0);
            this.Controls.SetChildIndex(this.pb_Save, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ToLearn_btn, 0);
            this.Controls.SetChildIndex(this.Delete_Story, 0);
            this.Controls.SetChildIndex(this.StoryNameCBox, 0);
            this.Controls.SetChildIndex(this.PlaySaved_lbl, 0);
            this.Controls.SetChildIndex(this.Save_lbl, 0);
            this.Controls.SetChildIndex(this.Mic_lbl, 0);
            this.Controls.SetChildIndex(this.RecordRec_lbl, 0);
            this.Controls.SetChildIndex(this.Help_Ico, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Help_Ico)).EndInit();
            this.TextToSpeech.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axQuest3DCtrl41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AdjustMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlaySaved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recognize_Pb)).EndInit();
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
        private System.Windows.Forms.PictureBox pb_AdjustMic;
        private System.Windows.Forms.PictureBox pb_PlaySaved;
        private System.Windows.Forms.PictureBox pb_Save;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ToLearn_btn;
        private System.Windows.Forms.ToolTip ToolTip_Save;
        private System.Windows.Forms.ToolTip Play_Saved_ToolTip;
        private System.Windows.Forms.ToolTip Adjust_Mic_Tooltip;
        private System.Windows.Forms.ToolTip Recognize_ToolTip;
        private System.Windows.Forms.PictureBox Delete_Story;
        private System.Windows.Forms.ToolTip Delete_ToolTip;
        private System.Windows.Forms.ComboBox StoryNameCBox;
        private System.Windows.Forms.Label PlaySaved_lbl;
        private System.Windows.Forms.Label Save_lbl;
        private System.Windows.Forms.Label Mic_lbl;
        private System.Windows.Forms.Label RecordRec_lbl;
        private System.Windows.Forms.PictureBox Recognize_Pb;
      //////  private AxQuest3DActiveX4Lib.AxQuest3DCtrl4 axQuest3DCtrl41;
    }
}