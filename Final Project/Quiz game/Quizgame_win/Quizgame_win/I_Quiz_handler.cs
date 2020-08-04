using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
   interface I_Quiz_handler
    {
        int Question_num { get; set; }
        string Question { get; set; }
         string option_a { get; set; }
         string option_b { get; set; }
         string option_c { get; set; }
         string option_d { get; set; }
        string correct_ans { get; set; }
        void show_ques();
    }
}
