using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
    class Admin_cls
    {
        public int Q_no { get; set; }
        public string new_Question { get; set; }
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }

        public string d { get; set; }
        public string Correct_ans { get; set; }

      
        public string Type { get; set; } // admin

        public int Login_ID { get; set; } // admin
        public string Login_Pass { get; set; } // admin


        public void M_ADD()
        {

            string query = "insert into Question_sheet values('" + new_Question + "','" + a + "','" + b + "','" + c + "','" + d + "','" + Correct_ans + "')";
            SqlCommand SC = new SqlCommand(query,Connection_cls.Get());
            SC.ExecuteNonQuery();

        }
       
        public void E_ADD()
        {

            string query = "insert into English_Question_sheet values('" + new_Question + "','" + a + "','" + b + "','" + c + "','" + d + "','" + Correct_ans + "')";
            SqlCommand SC = new SqlCommand(query, Connection_cls.Get());
            SC.ExecuteNonQuery();

        }
        // edit maths questions
        public void M_EDIT()
        {

            string query = "Update Question_sheet set Question ='" + new_Question + "', option_a='" + a + "', option_b='" + b + "', option_c='" + c + "',option_d = '" + d + "',correct_ans ='" + Correct_ans + "' where Question_num ='"+Q_no+"'";
            SqlCommand SC = new SqlCommand(query, Connection_cls.Get());
            SC.ExecuteNonQuery();

        }
        // edit english questions
        public void E_EDIT()
        {

            string query = "Update English_Question_sheet set Question ='" + new_Question + "', option_a='" + a + "', option_b='" + b + "', option_c='" + c + "',option_d = '" + d + "',correct_ans ='" + Correct_ans + "' where Question_num ='" + Q_no + "'";
            SqlCommand SC = new SqlCommand(query, Connection_cls.Get());
            SC.ExecuteNonQuery();

        }
        public void M_Delete()
        {
            string query = "delete Question_sheet where question_num ='" + Q_no + "'";
            SqlCommand SC = new SqlCommand(query, Connection_cls.Get());
            SC.ExecuteNonQuery();

        }
        public void E_Delete()
        {
            string query = "delete Question_sheet where question_num ='" + Q_no + "'";
            SqlCommand SC = new SqlCommand(query, Connection_cls.Get());
            SC.ExecuteNonQuery();

        }

        public void Check_admin(int ID)
        {
            SqlConnection sc = null;
            I_Connection con = new Connection_adapter();
            sc = con.Request(sc);
            string query = "select Login_ID,Login_Pass,Type from tbl_Login where Login_ID ='" + ID + "'";
            SqlCommand SC = new SqlCommand(query,con.Request(sc));
            SC.ExecuteNonQuery();

            SqlDataReader sdr = SC.ExecuteReader();
            while (sdr.Read())
            {
                Login_ID = (int)sdr["Login_ID"];
                Login_Pass = (string)sdr["Login_Pass"];         
                Type = (string)sdr["Type"];


            }
            sdr.Close();

        }
        //search for Maths Questions
        public void M_Search()
        {
//Connection_cls.Get().Close();
//Connection_cls.Get().Open();
            string query = "select * from Question_sheet where Question_num ='" + Q_no + "'";
            SqlCommand SC = new SqlCommand(query, Connection_cls.Get());
            
         
            SqlDataReader sdr = SC.ExecuteReader();
            while (sdr.Read())
            {
                new_Question = sdr["Question"].ToString();
                a = sdr["option_a"].ToString();
                b = sdr["option_b"].ToString();
                c = sdr["option_c"].ToString();
                d = sdr["option_d"].ToString();
               Correct_ans = sdr["correct_ans"].ToString();
            

            }
            sdr.Close();
//Connection_cls.Get().Close();
         
        }

        //search for English Questions
        public void E_Search()
        {
            string query = "select * from English_Question_sheet where Question_num ='" + Q_no + "'";
            SqlCommand SC = new SqlCommand(query, Connection_cls.Get());
           

            SqlDataReader sdr = SC.ExecuteReader();
            while (sdr.Read())
            {
                new_Question = sdr["Question"].ToString();
                a = sdr["option_a"].ToString();
                b = sdr["option_b"].ToString();
                c = sdr["option_c"].ToString();
                d = sdr["option_d"].ToString();
                Correct_ans = sdr["correct_ans"].ToString();


            }
            sdr.Close();

        }





    }
}
