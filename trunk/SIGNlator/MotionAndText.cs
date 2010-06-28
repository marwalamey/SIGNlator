using System;
using System.Collections.Generic;
using System.Text;

namespace SIGNlator
{
    class MotionAndText
    {
        private List<int> MotionNo = new List<int>();
        private List<string> Text = new List<string>();
        public void setMotionNo(int Mot)
        {
            MotionNo.Add(Mot);
        }
        public List<int> getMotioNo()
        {
            return MotionNo;
        }

        public void setText(string txt)
        {
            Text.Add(txt);
        }
        public List<string> getText()
        {
            return Text;
        }

    }
}
