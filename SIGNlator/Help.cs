using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIGNlator
{
    public partial class Help : Form
    {
        
        public Help()
        {
            InitializeComponent();
        }


        private void Help_Menu_DoubleClick(object sender, EventArgs e)
        {
            int selected = Help_Menu.SelectedIndex;
            switch (selected)
            {
                case 0:
                    Help_pb.BackgroundImage = new Bitmap("Welcome_Help copy.gif");
                    Help_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    break;
                case 1:

                    Help_pb.BackgroundImage = new Bitmap("Recognize_Help copy.gif");
                    Help_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    break;
                case 2:
                    Help_pb.BackgroundImage = new Bitmap("Save_Help copy.gif");
                    Help_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;


                    break;
                case 3:

                    Help_pb.BackgroundImage = new Bitmap("PlaySaved_Help copy.gif");
                    Help_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;


                    break;
                case 4:
                    Help_pb.BackgroundImage = new Bitmap("Delete_Help copy.gif");
                    Help_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;


                    break;
                case 5:
                    Help_pb.BackgroundImage = new Bitmap("Learn_Help copy.gif");
                    Help_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;



                    break;




            }
        }
    }
}
