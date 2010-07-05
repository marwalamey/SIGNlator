using System;
using System.Collections.Generic;
using System.Text;

namespace SIGNlator
{
    public class MotionAndPicture
    {
        private int MotionNo;
        private string Picture;
        public void setMotionNo(int Mot)
        {
            MotionNo = Mot;
        }
        public int getMotionNo()
        {
            return MotionNo;
        }
        public void setPic(string pic)
        {
            Picture = pic;
            //MotionNo = Mot;
        }
        public string getPic()
        {
            return Picture;
        }
    }
}
