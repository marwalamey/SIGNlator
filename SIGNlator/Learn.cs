using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaveLib.AudioMixer;

namespace SIGNlator
{
    public partial class Learn : Boundary
    {
        private System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection();
        private System.Data.SqlClient.SqlCommand sqlCom = new System.Data.SqlClient.SqlCommand();
        private bool toRecognize = false;
        Form welcomeForm = new Form();
        //private Core core = new Core();
        public Learn()
        {
            InitializeComponent();
        }
        public Learn(Form frm)
        {
            InitializeComponent();
            welcomeForm = frm;
 
        }

        ////private void TranslateTTS_Click(object sender, EventArgs e)
        ////{
        ////    string[] wordsInSentence = InputText.Text.Split(' ');
        ////    for (int i = 0; i < wordsInSentence.Length; i++)
        ////    {
        ////        core.Run_Text_To_Sign_Learn(wordsInSentence[i]);
        ////    }
        ////    InputText.Clear();
        ////    // InputText.Text = MotionNo;
        ////}

        private void Record_Story_Click(object sender, EventArgs e)
        {
            core.Record_Speech();
        }

        private void Show_Sign_Click(object sender, EventArgs e)
        {
            core.Save_Speech();
            core.Run_Recognizer(true);
        }

        private void Learn_Load(object sender, EventArgs e)
        {
            //********************initialization of list box***************************/
            List<string> WordsWithPictures = new List<string>();
            WordsWithPictures= core.get_Words_With_Pictures();
            
            //core.get_Words_With_Pictures();
            
            int i = 0;
            int j = WordsWithPictures.Count;
            for (i = 0; i < j; i++)
            {
                VocabularyListBox.Items.Add(WordsWithPictures[i]);
            }
            //********************initialization of quest URL***************************/
            string extraString = System.Reflection.Assembly.GetExecutingAssembly().Location; //path of application

            for (int k = extraString.Length - 1; k > 0; k--)
            {
                if (extraString[k] == '\\')
                {
                    extraString = extraString.Remove(k + 1);
                    break;
                }
            }
            extraString += "StartGroupWeb.q3d";
            axQuest3DCtrl41.Url = extraString;

            
        }




        private void Double_Clicked_Item(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("u double clicked"+ VocabularyListBox.SelectedItem);
             
            MotionAndPicture MotNPic = new MotionAndPicture();
            string input = VocabularyListBox.SelectedItem.ToString();
            LearnedWord.Text = input;
            LearnedWord.Font =  new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LearnedWord.Refresh();
            MotNPic = core.Run_Text_To_Sign_Learn(input);
            int motionNo = MotNPic.getMotionNo();

            try
            {
                LearningPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                LearningPicBox.BackgroundImage = new Bitmap(MotNPic.getPic());
                LearningPicBox.Refresh();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsupported picture");
            }
            if (motionNo != -1)
            {
                //call quest here
                //InputText.Text += Convert.ToString(motionNo); //only for check
                 Change_Motion(motionNo);
            }
            else
            {
                MessageBox.Show("'" + input+ "'" + "  is out of scope");
            }
            
   
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

       

        private void Learn_Closed(object sender, FormClosedEventArgs e)
        {
            if (toRecognize == false)
            {
                welcomeForm.Close();
                

            }

        }

        private void ToRec_btn_Click(object sender, EventArgs e)
        {
            toRecognize = true; 
            Recognize rec = new Recognize(welcomeForm);
            rec.Show();
            this.Close();

        }

        private void VocabularyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      




    }
}
