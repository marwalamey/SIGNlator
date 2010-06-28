using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;




namespace SIGNlator
{
    class DBManager
    {
        private string constr; 
        private System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection();
        private System.Data.SqlClient.SqlCommand sqlCmd = new System.Data.SqlClient.SqlCommand();
        private MotionAndPicture MotAndPic = new MotionAndPicture();
        /// <summary>
        /// Return the motion number to run quest
        /// </summary>
        /// <returns></returns>
        public int Get_Motion(string InputWord)
        {
            int r = 0;
            SqlDataReader reader = null;

            reader = select("GetSign " + "N'" + InputWord + "'");

            while (reader.Read())
            {
                r = Convert.ToInt32(reader[0]);
            }
            //close the connection
            sqlCon.Close();

            return r;
        }
        /// <summary>
        /// Return motion number and picture of the motion for the learning mode
        /// </summary>
        /// <returns></returns>
        public MotionAndPicture Get_Motion_And_Picture(string InputWord)
        {
            //to be changed
            return MotAndPic;
        }
        /// <summary>
        /// Get comuter name and 
        /// </summary>
        public void setdb()
        {

            string extraString = System.Reflection.Assembly.GetExecutingAssembly().Location; //path of application
            string computerName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            for (int i = extraString.Length - 1; i > 0; i--)
            {
                if (extraString[i] == '\\')
                {
                    extraString = extraString.Remove(i + 1);
                    break;
                }   
            }
            for (int j = 0; j < computerName.Length; j++)
            {
                if (computerName[j] == '\\')
                {
                    computerName = computerName.Remove(j + 1);
                    break;
                }
            }
            constr = @"Data Source=" + computerName + ";AttachDbFilename=" + extraString + "SignLanguage.mdf;Integrated Security=True";
        }

        /// <summary>
        /// Runs select query from database
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public SqlDataReader select(string command)
        {
            setdb();
            this.sqlCon.ConnectionString = constr;
            this.sqlCmd.Connection = this.sqlCon;
            SqlDataReader reader = null;
            try
            {
                sqlCon.Open();
                sqlCmd.CommandText = command;
                reader = sqlCmd.ExecuteReader();

            }
            catch (Exception ex)
            {
               
            }
            return reader;

        }

    }
}
