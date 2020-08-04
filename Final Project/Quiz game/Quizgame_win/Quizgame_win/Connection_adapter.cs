using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
    class Connection_adapter : I_Connection
    {
        private SqlConnection Req = null;
        public SqlConnection Request(SqlConnection req)
        {

            SqlConnection con = Connection_cls.Get(req);
            return con;
        }
    }
}
