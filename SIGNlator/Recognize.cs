using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaveLib.AudioMixer;
using System.Globalization;
using System.Threading;


namespace SIGNlator
{
    public partial class Recognize : Boundary
    {
        private bool Save = false;
        private Core core = new Core();
        private List<string> StoryName = new List<string>();
        int counterRec = 0;
        Form welcomeForm = new Form();
        public bool toLearn = false;


        public Recognize(Form wf)
        {
            InitializeComponent();
            welcomeForm = wf;
            StoryName = core.Retrieve_Saved_Stories();
            for (int i = 0; i < StoryName.Count; i++)
            {
                StoryNameCBox.Items.Add(StoryName[i]);
            }
        }
        public Recognize()
        {
            InitializeComponent();
            toLearn = false;
             StoryName = core.Retrieve_Saved_Stories();
            for (int i = 0; i < StoryName.Count; i++)
            {
                StoryNameCBox.Items.Add(StoryName[i]);
            }
            
        }
       

        private void TranslateTTS_Click(object sender, EventArgs e)
        {
            core.Text_Clear();
            core.MotionSeq_Clear();
            string inputTextString = InputText.Text;
            string[] wordsInSentence = inputTextString.Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int motionNo;
            int motionNo_Vowelized;
            // for (int i = wordsInSentence.Length-1; i >=0 ; i--)
            for (int i = 0; i < wordsInSentence.Length; i++)
            {
                motionNo = core.Run_Text_To_Sign(wordsInSentence[i]);
                motionNo_Vowelized = core.Run_Text_To_Sign_Vowelized(wordsInSentence[i]);
                if (motionNo != -1 || motionNo_Vowelized != -1)
                {
                    //call quest here
                    //InputText.Text += Convert.ToString(motionNo); //only for check
                    if ((motionNo == motionNo_Vowelized) || (motionNo != -1 && motionNo_Vowelized == -1))
                    {
                        if (motionNo != 0)
                            Change_Motion(motionNo);

                    }
                    else if (motionNo_Vowelized != -1 && motionNo == -1)
                    {
                        if (motionNo != 0)
                            Change_Motion(motionNo_Vowelized);

                    }
                }
                else
                {
                    MessageBox.Show("'" + wordsInSentence[i] + "'" + "  is out of scope");
                }


            }
 
            
           
        }


        /// <summary>
                /// Open file and read sequence of motions and call quest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-eg");
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ar-eg");
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

     
        private void RecBtn_hover(object sender, EventArgs e)
        {
            Recognize_Pb.Size = new System.Drawing.Size(49, 35);

        }

        private void RecBtn_Leave(object sender, EventArgs e)
        {
            Recognize_Pb.Size = new System.Drawing.Size(53, 39);
           

        }

 
        private void Savebtn_Hover(object sender, EventArgs e)
        {
            pb_Save.Size = new System.Drawing.Size(46, 41);

        }

        private void Savebtn_Leave(object sender, EventArgs e)
        {
            pb_Save.Size = new System.Drawing.Size(50, 45);
            

        }

        public void Recognize_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (toLearn == false)
            {
                welcomeForm.Close();
            }

        }


        private void axQuest3DCtrl41_OnEvent(object sender, AxQuest3DActiveX4Lib._IQuest3DCtrl4Events_OnEventEvent e)
        {

        }

        private void PlayBtn_Hover(object sender, EventArgs e)
        {
            pb_PlaySaved.Size = new System.Drawing.Size(46, 41);

        }

        private void PlayBtn_Leave(object sender, EventArgs e)
        {
            pb_PlaySaved.Size = new System.Drawing.Size(50, 45);

        }

        private void Adjust_hover(object sender, EventArgs e)
        {
            pb_AdjustMic.Size = new System.Drawing.Size(46, 41);

        }

        private void Adjust_leave(object sender, EventArgs e)
        {
            pb_AdjustMic.Size = new System.Drawing.Size(50, 45);

        }

        private void Delete_Hover(object sender, EventArgs e)
        {
            Delete_Story.Size = new System.Drawing.Size(32,26);
        }

        private void Delete_Leave(object sender, EventArgs e)
        {
            Delete_Story.Size = new System.Drawing.Size(36, 30);

        }

        private void Delete_Story_Click(object sender, EventArgs e)
        {
            if (StoryNameCBox.SelectedItem != null)
            {
                string SelectedItems = StoryNameCBox.SelectedItem.ToString();
                DialogResult dr;
                dr = MessageBox.Show("Are you sure you wish to delete " +
                    StoryNameCBox.SelectedItem.ToString() + "?",
                                "Confirmation",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                else//law das 3la yes
                {
                    bool isDeleted = core.Delete_Story(StoryNameCBox.SelectedItem.ToString());
                    if (isDeleted)
                    {
                        MessageBox.Show(SelectedItems + " Deleted successfully");
                        StoryNameCBox.Items.Remove(SelectedItems);

                    }
                    else//law kan 7asal error gowa
                    {
                        MessageBox.Show("Error in deleting " + SelectedItems);
                    }
                }

            }
            else //law makansh fih 7aga m5tarha fel drop down menu
            {
                if (StoryNameCBox.Items.Count != 0)//law kan fih 7agat saved bas ma5tarsh
                {
                    MessageBox.Show("Please select a story to delete");
                }
                else//law makansh fih stories aslan w howa das ymsa7
                {
                    MessageBox.Show("No saved stories exist");

                }
            }

        }

        private void SaveStoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;

        }

        private void InputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
          && !char.IsLetterOrDigit(e.KeyChar)
           && e.KeyChar != '.' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }


        private void Recognize_Pb_Click(object sender, EventArgs e)
        {
            if (counterRec == 0)
            {
                counterRec++;
                Recognize_Pb.BackgroundImage = new Bitmap("RecOff copy.gif");
                core.Record_Speech();
                //RecordRec_lbl.Refresh();
                RecordRec_lbl.Text = "Stop and translate";
                RecordRec_lbl.Refresh();

            }
            else if (counterRec == 1)
            {
                core.MotionSeq.Clear();
                counterRec = 0;
                Recognize_Pb.BackgroundImage = new Bitmap("RecOff1 copy.gif");
                Recognize_Pb.Refresh();
                RecordRec_lbl.Text = "Narrate a story";
                RecordRec_lbl.Refresh();
                core.Save_Speech();

                List<int> mot = core.Run_Recognizer(false);
                List<string> RecWords = core.Return_Words();
                int NoOfWords = RecWords.Count;
                InputText.Clear();

                for (int k = 0; k < NoOfWords; k++)
                {
                    InputText.Text += RecWords[k] + " ";
                }
                InputText.Refresh();
              
                int i = 0;
                int NoOfMot = mot.Count;
                for (i = 0; i < NoOfMot; i++)
                {
                    if (mot[i] != 0)

                        Change_Motion(mot[i]);


                }
                /******************************************************************************/
                core.Text_Clear();
                core.MotionSeq_Clear();
                string inputTextString = InputText.Text;
                string[] wordsInSentence = inputTextString.Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int motionNo;
                int motionNo_Vowelized;
                // for (int i = wordsInSentence.Length-1; i >=0 ; i--)
                for (int j = 0; j < wordsInSentence.Length; j++)
                {
                    motionNo = core.Run_Text_To_Sign(wordsInSentence[j]);
                    motionNo_Vowelized = core.Run_Text_To_Sign_Vowelized(wordsInSentence[j]);
                }
                /******************************************************************************/

                //
            }
        }

        private void pb_PlaySaved_Click(object sender, EventArgs e)
        {
            try
            {
                InputText.Clear();
                MotionAndText MotAndtxt = core.Play_Saved_Stories(Convert.ToString(StoryNameCBox.SelectedItem));

                for (int i = 0; i < MotAndtxt.getMotioNo().Count; i++)
                {

                    InputText.Text += " " + MotAndtxt.getText()[i];
                    InputText.Refresh();
                    Change_Motion(MotAndtxt.getMotioNo()[i]);
                }
                MotAndtxt.Reset_MotionAndText();
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a saved story to play");
            }
        }

        private void pb_Save_Click(object sender, EventArgs e)
        {
            if (SaveStoryName.Text.Length != 0)
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
            else
            {
                MessageBox.Show("Please Enter first a story name");
            }
        }

        private void pb_AdjustMic_Click(object sender, EventArgs e)
        {
            MixerTest.MixerForm mixerForm = new MixerTest.MixerForm();
            mixerForm.Show();
        }

        private void ToLearn_btn_Click(object sender, EventArgs e)
        {
            toLearn = true;
            Learn lrn = new Learn(welcomeForm);
            lrn.Show();
            this.Close();
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            //t.Start();
            //this.Close();
        }

       

      

    


    } 
}
