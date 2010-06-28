using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SIGNlator
{
    class SavedStory
    {
        List<string> StoryNames = new List<string>();
        List<int> MotionSequence = new List<int>();
        MotionAndText MotAndTxt = new MotionAndText();
        /// <summary>
        /// open files and save the sequence and name the file with story name
        /// and save story name in the file called StoryNames
        /// </summary>
        /// <param name="MotionSequence"></param>
        /// <param name="StoryName"></param>
        public int Save_Story(List<string> Text, List<int> MotionSequence,string StoryName)
        {
            if (Text.Count == MotionSequence.Count)
            {
                // create a writer and open the file
                string extraString = System.Reflection.Assembly.GetExecutingAssembly().Location; //path of application
                for (int i = extraString.Length - 1; i > 0; i--)
                {
                    if (extraString[i] == '\\')
                    {
                        extraString = extraString.Remove(i + 1);
                        break;
                    }
                }
                extraString += @"Saved Stories\";
                TextWriter writer = new StreamWriter(extraString + StoryName + ".txt");

                // write a line of text to the file
                string line;
                for (int i = 0; i < Text.Count; i++)
                {
                    line = Text[i] +  " " +MotionSequence[i];
                    writer.WriteLine(line);
                }

                // close the stream
                writer.Close();
                return 1;
            }
            else
            {
                return -1;
            }
        }
        /// <summary>
        /// Returns a list of the stories' names
        /// </summary>
        /// <returns></returns>
        public List<string> Retrive_Saved_Stories()
        {
            StoryNames.Clear();
            string extraString = System.Reflection.Assembly.GetExecutingAssembly().Location; //path of application
            for (int i = extraString.Length - 1; i > 0; i--)
            {
                if (extraString[i] == '\\')
                {
                    extraString = extraString.Remove(i + 1);
                    break;
                }
            }
            extraString += @"Saved Stories\";
            DirectoryInfo dir = new DirectoryInfo(extraString);
            FileInfo[] txtfiles = dir.GetFiles("*.txt");
            //Console.WriteLine("Total number of bmp files", bmpfiles.Length);
            for (int i = 0; i < txtfiles.Length; i++)
            {
                StoryNames.Add(txtfiles[i].Name);
            }
            return StoryNames; 
        }
        /// <summary>
        /// Search for story name on the file and retrieves sequence of motions
        /// </summary>
        /// <param name="StoryName"></param>
        /// <returns></returns>
        public MotionAndText Play_Saved_Stories(string StoryName)
        {
            //open file and fill list of motions and text then return it
            string extraString = System.Reflection.Assembly.GetExecutingAssembly().Location; //path of application
            for (int i = extraString.Length - 1; i > 0; i--)
            {
                if (extraString[i] == '\\')
                {
                    extraString = extraString.Remove(i + 1);
                    break;
                }
            }
            extraString += @"Saved Stories\";
            TextReader reader = new StreamReader(extraString + StoryName);

            // read a line from file
            string line;
            while (reader.Read() != -1)
            {
                line = reader.ReadLine();
                string[] TextMotln = line.Split(' ');
                MotAndTxt.setMotionNo(Convert.ToInt32(TextMotln[1]));
                MotAndTxt.setText(TextMotln[0]);
            }

            // close the stream
            reader.Close();
            return MotAndTxt;
        }
    }
}
