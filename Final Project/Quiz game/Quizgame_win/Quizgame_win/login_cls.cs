using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
    class login_cls 
    {


        public int Login_ID { get; set; }
        public int Login_Pass { get; set; }

        public string Type { get; set; }

        public decimal T_Marks { get; set; }

      

        public void ADD()

       {

            string query = "insert into tbl_Login values('" + Login_ID + "','" + Login_Pass + "','" + T_Marks + "','" + Type + "') ";
            SqlCommand SC = new SqlCommand(query, Connection_cls.Get());
            SC.ExecuteNonQuery();

        }
    }
}
