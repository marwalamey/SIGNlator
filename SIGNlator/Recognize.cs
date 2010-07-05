﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaveLib.AudioMixer;

namespace SIGNlator
{
    public partial class Recognize : Boundary
    {
        private bool Save = false;
        private Core core = new Core();
        private List<string> StoryName = new List<string>();
        int counterRec = 0;


        public Recognize()
        {
            InitializeComponent();
        }

        private void TranslateTTS_Click(object sender, EventArgs e)
        {
            string[] wordsInSentence = InputText.Text.Split(' ');
            int motionNo;
            for (int i = 0; i < wordsInSentence.Length; i++)
            {
                motionNo = core.Run_Text_To_Sign(wordsInSentence[i]);
                if (motionNo != -1)
                {
                    //call quest here
                    //InputText.Text += Convert.ToString(motionNo); //only for check
                    Change_Motion(motionNo);
                }
                else
                {
                    MessageBox.Show("'" + wordsInSentence[i] + "'" + "  is out of scope" );
                }

               
            }
        }

        private void Show_Sign_Click(object sender, EventArgs e)
        {
            core.Save_Speech();
            List<int> mot= core.Run_Recognizer(false);
            int i = 0;
            int NoOfMot = mot.Count;
            for (i = 0; i < NoOfMot; i++)
            {
        
                Change_Motion(mot[i]);
                
                
            }
            mot.Clear();
            
        }

        private void Save_Story_Click(object sender, EventArgs e)
        {
            int IsSaved = core.Save_Story(SaveStoryName.Text);
            if (IsSaved == 1)
            {
                MessageBox.Show("Story saved");
            }
            else
                MessageBox.Show("Error saving story");
        }
        /// <summary>
                /// Open file and read sequence of motions and call quest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaySaved_Click(object sender, EventArgs e)
        {
            core.Play_Saved_Stories(StoryNameCBox.SelectedText);
        }
        /// <summary>
        /// open file and display the list of saved stories in combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Saved_Stories_Click(object sender, EventArgs e)
        {
            StoryNameCBox.Items.Clear();
            StoryName = core.Retrieve_Saved_Stories();
            for (int i = 0; i < StoryName.Count; i++)
            {
                StoryNameCBox.Items.Add(StoryName[i]);
            }
        }

        private void Record_Story_Click(object sender, EventArgs e)
        {
            core.Record_Speech();
  
        }

        private void Recognize_Load(object sender, EventArgs e)
        {
            string extraString = System.Reflection.Assembly.GetExecutingAssembly().Location; //path of application
           
            for (int i = extraString.Length - 1; i > 0; i--)
            {
                if (extraString[i] == '\\')
                {
                    extraString = extraString.Remove(i + 1);
                    break;
                }
            }
            extraString += "StartGroupWeb.q3d";
            axQuest3DCtrl41.Url = extraString;

            
        }
        public void Change_Motion(int mot)
        {
            //MessageBox.Show("I've entered Change_Motion ");

           // axQuest3DCtrl41.Url = @"E:\4th Year\GP\Mapping Marwa\StartGroup.q3d";

            axQuest3DCtrl41.GetOcx();




            float cv = axQuest3DCtrl41.get_ChannelValue("StartGroup", "Switch");
           // MessageBox.Show(cv.ToString());
            axQuest3DCtrl41.SetChannelValue("StartGroup", "Switch", mot);
            cv = axQuest3DCtrl41.get_ChannelValue("StartGroup", "Switch");
            
            System.Threading.Thread.Sleep(2000);
            axQuest3DCtrl41.SetChannelValue("StartGroup", "Switch", 0);
            System.Threading.Thread.Sleep(50);

        }

        private void Adjust_Click(object sender, EventArgs e)
        {
            MixerTest.MixerForm mixerForm = new MixerTest.MixerForm();
            mixerForm.Show();
        }

        private void PlaySavedStories_Click(object sender, EventArgs e)
        {
            MotionAndText MotAndtxt = core.Play_Saved_Stories(Convert.ToString(StoryNameCBox.SelectedItem));
            
            for (int i = 0; i < MotAndtxt.getMotioNo().Count; i++)
            {
                InputText.Clear();
                InputText.Text += " " + MotAndtxt.getText()[i];
                Change_Motion(MotAndtxt.getMotioNo()[i]);
            }
            MotAndtxt.Reset_MotionAndText();

        }

        private void Record_Clicked(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (counterRec == 0)
            {
                counterRec++;
                pictureBox1.BackgroundImage = new Bitmap("RecOff copy.gif");
                core.Record_Speech();

            }
            else if (counterRec == 1)
            {
                counterRec = 0;
                pictureBox1.BackgroundImage = new Bitmap("RecOff1 copy.gif");
                core.Save_Speech();
                List<int> mot = core.Run_Recognizer(false);
                int i = 0;
                int NoOfMot = mot.Count;
                for (i = 0; i < NoOfMot; i++)
                {

                    Change_Motion(mot[i]);


                }
                mot.Clear();
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

            int IsSaved = core.Save_Story(SaveStoryName.Text);
            if (IsSaved == 1)
            {
                MessageBox.Show("Story saved");
                StoryNameCBox.Items.Clear();
                StoryName = core.Retrieve_Saved_Stories();
                for (int i = 0; i < StoryName.Count; i++)
                {
                    StoryNameCBox.Items.Add(StoryName[i]);
                }
            }
            else
                MessageBox.Show("Error saving story");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            MixerTest.MixerForm mixerForm = new MixerTest.MixerForm();
            mixerForm.Show();

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            MotionAndText MotAndtxt = core.Play_Saved_Stories(Convert.ToString(StoryNameCBox.SelectedItem));

            for (int i = 0; i < MotAndtxt.getMotioNo().Count; i++)
            {
                InputText.Clear();
                InputText.Text += " " + MotAndtxt.getText()[i];
                Change_Motion(MotAndtxt.getMotioNo()[i]);
            }
            MotAndtxt.Reset_MotionAndText();
        }


    }
}
