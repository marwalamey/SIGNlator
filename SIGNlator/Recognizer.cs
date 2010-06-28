using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
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
            mciSendString("set recsound bitspersample 16 channels 2 alignment 2 samplespersec 16000 bytespersec 64000 format tag pcm wait", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
        }
        public void Save_Speech()
        {
            // stop and save
            mciSendString("save recsound " + "Input.wav", "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);
        }
        /// <summary>
        /// This runs HTK and returns the recognized word
        /// </summary>
        /// <returns></returns>
        public List<string> Recognize()
        {
            return RecognizedText; //to changed
        }
        /// <summary>
        /// Runs HTK command for adaptation
        /// </summary>
        public void Adaptation()
        {
        }
    }
}
