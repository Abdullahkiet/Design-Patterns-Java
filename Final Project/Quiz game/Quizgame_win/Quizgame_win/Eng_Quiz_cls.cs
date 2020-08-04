using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
    class Eng_Quiz_cls : I_Quiz_handler


        

    {
        public int Question_num { get; set; }
        public string Question { get; set; }
        public string option_a { get; set; }
        public string option_b { get; set; }
        public string option_c { get; set; }
        public string option_d { get; set; }
        public string correct_ans { get; set; }

        private I_Quiz_handler IHandler;
        public Eng_Quiz_cls(I_Quiz_handler I)
        {
            this.IHandler = I;
        }


        public void show_ques()
        {
            string query = "select * from English_Question_sheet where Question_num = '" + Question_num + "'";
            SqlCommand SC = new SqlCommand(query, Connection_cls.Get());
            SC.ExecuteNonQuery();

            SqlDataReader sdr = SC.ExecuteReader();
            while (sdr.Read())
            {
                Question = (string)sdr["Question"];
                option_a = (string)sdr["option_a"];
                option_b = (string)sdr["option_b"];
                option_c = (string)sdr["option_c"];
                option_d = (string)sdr["option_d"];
                correct_ans = (string)sdr["correct_ans"];



            }
            sdr.Close();


        }

    }
}
