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
    public partial class Learn : Form
    {
        private System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection();
        private System.Data.SqlClient.SqlCommand sqlCom = new System.Data.SqlClient.SqlCommand();
        private Core core = new Core();
        public Learn()
        {
            InitializeComponent();
        }

        private void TranslateTTS_Click(object sender, EventArgs e)
        {
            string[] wordsInSentence = InputText.Text.Split(' ');
            for (int i = 0; i < wordsInSentence.Length; i++)
            {
                core.Run_Text_To_Sign_Learn(wordsInSentence[i]);
            }
            InputText.Clear();
            // InputText.Text = MotionNo;
        }

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

        }

       

    }
}
