using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SIGNlator
{
    class Recognizer
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        private List<string> RecognizedText = new List<string>();



        public void Record_Speech()
        {
            // record from microphone
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("set recsound bitspersample 16 channels 1 alignment 2 samplespersec 16000 bytespersec 64000 format tag pcm wait", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
        }
        public void Save_Speech()
        {
            // stop and save
            string path = get_path();

            mciSendString("save recsound Input.wav", "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);
        }

        /// <summary>
        /// This runs HTK and returns the recognized word
        /// </summary>
        /// <returns></returns>
        public List<string> Recognize()
        {
            string path = get_path();
          //  string OP = Exec("HCopy -T 1 -C Config.conf -S test.scp", path);
           /// OP = Exec("HVite -C RecConfig.conf  -H model/hmm18/macros.mmf -H model/hmm18/hmmdefs.mmf -l  *  -i out.mlf -w networkLM.slf -p 0.0 -s 5.0 -S testWav.scp dictV4.txt tiedlist", path);
            List<string> temp = new List<string>();
          //  if (OP == " WARNING [-8013]  ReadDict: !NULL entry contains pronunciation in HVite\r\n")
            temp = get_words();


            //  temp.Add("أنًّكَ");
            return temp;
        }
        /// <summary>
        /// Runs HTK command for adaptation
        /// </summary>
        public void Adaptation()
        {
        }

        public string get_path()
        {

            string extraString = Application.ExecutablePath;

            for (int i = extraString.Length - 1; i > 0; i--)
                if (extraString[i] == '\\')
                {
                    extraString = extraString.Remove(i + 1);
                    break;
                }
            return extraString;
        }

        public string Exec(string CommandLine)
        {
            try
            {
                string buffer;
                string[] splitters = { " " };
                string cmd = CommandLine.Split(splitters, StringSplitOptions.RemoveEmptyEntries)[0];
                string args = CommandLine.Substring(cmd.Length + 1);
                Process a = new Process();

                a.StartInfo.FileName = cmd;
                a.StartInfo.Arguments = args;
                a.StartInfo.RedirectStandardOutput = true;
                a.StartInfo.UseShellExecute = false;
                a.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                a.StartInfo.CreateNoWindow = true;
                a.Start();
                buffer = a.StandardOutput.ReadToEnd();
                a.WaitForExit();

                while (a.HasExited == false)
                {
                    a.Dispose();
                    a.Close();
                }

                return buffer;
            }
            catch (Exception e)
            {

                return e.Message; ;
            }
        }
        public string Exec(string CommandLine, string workingfolder)
        {
            try
            {
                string current = System.IO.Directory.GetCurrentDirectory();
                System.IO.Directory.SetCurrentDirectory(workingfolder);
                string output = Exec(CommandLine);
                System.IO.Directory.SetCurrentDirectory(current);
                return output;
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        /// <summary>
        /// added by mona...to process the output file
        /// </summary>
        public List<string> get_words()
        {
            List<string> temp = new List<string>();
            string path = get_path();
            string line;


            StreamReader file = new StreamReader(path + "out.mlf", Encoding.GetEncoding("windows-1256"));
            int counter = 0;

            while ((line = file.ReadLine()) != null)
            {

                counter++;
                string[] words = line.Split(' ');
                if (counter >= 3)
                {
                    if (words[0] == ".")
                    {
                        break;
                    }
                    if (words[2] != "sil" && words[2] != "!ENTER" && words[2] != "!EXIT")
                    {
                        temp.Add(words[2]);

                    }
                    



                }


            }
            file.Close();
            return temp;

        }
    }
}
