using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
    class check_Facade_cls
    {
        I_QUIZ newQuiz = null;
        public I_QUIZ Createnewquiz(string type)
        {
            switch (type)
            {
                case "Maths":
                    break;
                case "English":
                    break;

                default:
                    break;
            }
            return newQuiz;

        }
    }
}
