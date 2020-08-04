using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
    interface I_Admin_Authent
    {
         string com1_text { get; set; }
         int Login_ID { get; set; }
         string Login_Pass { get; set; }
         int check { get; set; }

        int authentication();
    }
}
