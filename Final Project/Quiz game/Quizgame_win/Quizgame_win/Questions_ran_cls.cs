using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
   public static class Questions_ran_cls
    {

        static bool Contains(int[] array, int value, int up)
        {
            for (int i = 0; i < up; i++)
            {
                if (array[i] == value) return true;
            }
            return false;
        }


        public static int[] get()
        {


            int[] x = new int[5];
            Random r = new Random();


            for (int i = 0; i < x.Length; i++)
            {
                int next = 0;
                while (true)
                {
                    next = r.Next(1, 10);

                    if (Contains(x, next, i) == false)

                        break;
                }

                x[i] = next;
            }
            return x;



        }
    }
}
