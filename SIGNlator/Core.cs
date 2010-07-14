using System;
using System.Collections.Generic;
using System.Text;





namespace SIGNlator
{
    public class Core
    {
        private DBManager DBMgr = new DBManager();
        private object SpeechWav;// to be of type wav
        public List<int> MotionSeq = new List<int>();
        private List<string> Text = new List<string>();
        private bool Picture;
        private List<string> Word = new List<string>();
        private int MotionNo=1;
        private Recognizer Recognizer = new Recognizer();
        private SavedStory SaveStory = new SavedStory();
        private MotionAndPicture MotAndPic = new MotionAndPicture();
        List<MotionAndPicture> ListMotAndPic = new List<MotionAndPicture>();
        private string Pic; //to be changed to type 

        public List<string> Return_Words()
        {
            return Word;
        }

        public List<int> Run_Recognizer(bool pic)
        {
            Word = Recognizer.Recognize(); // calling HTK
            for (int i = 0; i < Word.Count; i++)
            {
                if (pic == false)
                {
                      MotionNo = DBMgr.Get_Motion(Word[i]);
                      MotionSeq.Add(MotionNo);
                }
                else
                {
                    MotionNo = (DBMgr.Get_Motion_And_Picture(Word[i])).getMotionNo();
                    MotAndPic.setMotionNo(MotionNo);

                    Pic = (DBMgr.Get_Motion_And_Picture(Word[i])).getPic();
                    MotAndPic.setPic(Pic);

                    ListMotAndPic.Add(MotAndPic);


                }
               
                
            }
            return MotionSeq;
            

        }
        /// <summary>
        /// searches in the unvowelized column
        /// </summary>
        /// <param name="wordInSentence"></param>
        /// <returns></returns>
        public int Run_Text_To_Sign(string wordInSentence)
        {
            MotionNo = DBMgr.Get_Motion_TTS(wordInSentence);
            if (MotionNo != 0)
                {
                MotionSeq.Add(MotionNo);
                Text.Add(wordInSentence);
            }
            else
            {
                MotionNo = -1;
            }
            return MotionNo;

        }
        public int Run_Text_To_Sign_Vowelized(string wordInSentence)
        {
            MotionNo = DBMgr.Get_Motion(wordInSentence);
            if (MotionNo != 0)
            {
                MotionSeq.Add(MotionNo);
                Text.Add(wordInSentence);
            }
            else
            {
                MotionNo = -1;
            }
            return MotionNo;
        }
        /// <summary>
        /// To be called in learn mode for translating text to sign
        /// </summary>
        /// <param name="wordInSentence"></param>
        /// <returns></returns>
        public MotionAndPicture Run_Text_To_Sign_Learn(string wordInSentence)
        {
            MotionNo = (DBMgr.Get_Motion_And_Picture(wordInSentence)).getMotionNo();
            MotAndPic.setMotionNo(MotionNo);

            Pic = (DBMgr.Get_Motion_And_Picture(wordInSentence)).getPic();
            MotAndPic.setPic(Pic);

            ListMotAndPic.Add(MotAndPic);
            return MotAndPic;

        }
        public void Run_Adaptation()
        {
            Recognizer.Adaptation();
        }
        
        /// <summary>
        /// Save the sequence of motions (numbers) of the narrated story in a text file
        /// </summary>
        public int Save_Story(string StoryName)
        {
            int IsSaved = SaveStory.Save_Story(Text, MotionSeq, StoryName);
            return IsSaved;
        }
        public void Record_Speech()
        {
            Recognizer.Record_Speech();
        }
        public void Save_Speech()
        {
            Recognizer.Save_Speech();
        }
        public List<string> Retrieve_Saved_Stories()
        {
            return SaveStory.Retrive_Saved_Stories();
        }
        public MotionAndText Play_Saved_Stories(string SelectedStoryName)
        {
            return SaveStory.Play_Saved_Stories(SelectedStoryName);
        }
        public List<string> get_Words_With_Pictures()
        {
            List<string> WordsWithPictures= new List<string>();
            WordsWithPictures = DBMgr.Get_Words_With_Pictures();
            
            //DBMgr.Get_Words_With_Pictures();
            return WordsWithPictures;
        }
        public void MotionSeq_Clear()
        {
            MotionSeq.Clear();
        }
        public void Text_Clear()
        {
            Text.Clear();
        }
        public bool Delete_Story(string StoryName)
        {
            bool isSaved=SaveStory.Delete_Saved_Story(StoryName);
            return isSaved;
        }
    }
}
