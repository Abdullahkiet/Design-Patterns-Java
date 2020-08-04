using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
    class check_Score_cls
    {
        public string radio_1 { get; set; }
        public string radio_2 { get; set; }
        public string radio_3 { get; set; }
        public string radio_4 { get; set; }
        public string correct_ans { get; set; }
        public string ans { get; set; }
        public int T_marks { get; set; }

        public string Ques_label { get; set; }

        public int count = 0;
       // Questions_ran_cls rg = new Questions_ran_cls();
        //I_Quiz_handler qs = new Quiz_cls();
     
        
        //public void genrelize()
        //{
        //    int[] y = rg.get();

        //}
       I_Quiz_handler q = new Quiz_cls();
        public void ques_count( int i)
        {            
          
            if (count < 5)
            {

                

                q.Question_num =i;

                q.show_ques();
                Ques_label = q.Question;
                radio_1 = q.option_a;
                radio_2 = q.option_b;
                radio_3 = q.option_c;
                radio_4 = q.option_d;
                correct_ans = q.correct_ans;

            }       
                       

        }

        public void check()
        {

            if (ans == correct_ans)
            {
                if (count == 5)
                {
                    T_marks++;
                }
                T_marks++;
                count++;
            }
            else
            {
                count++;
            } 
           



        }

    }
}
