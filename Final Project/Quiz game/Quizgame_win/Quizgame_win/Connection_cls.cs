using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
   public class Connection_cls 
    {
        private Connection_cls() { }

        //singleton pattern
        private static SqlConnection Sc = null;
        public static SqlConnection Get()
        {
            if (Sc == null)
            {
                Sc = new SqlConnection();
                Sc.ConnectionString = @"Data Source=AB-PC\;Initial Catalog=Dp_quiz;Integrated Security=True";
                Sc.Open();

            }
            return Sc;

        }
        //adapter pattern


        public static SqlConnection Get(SqlConnection sc)
        {
            Sc = sc;
            if (Sc == null)
            {
                Sc = new SqlConnection();
                Sc.ConnectionString = @"Data Source=AB-PC\;Initial Catalog=Dp_quiz;Integrated Security=True; Integrated Security=True";
                Console.WriteLine("connnection Open ");
                Sc.Open();

            }
            return Sc;

        }


    
}
}
