using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            // Complete this function
            if (v1 <= v2) //Since x1 is always less than x2 (different starting point), the two kangaroos will never catch up if "x1-kangaroo" move slower or at the same speed as "x2-kangaroo"
                return "NO";

            //At this point, "v2 - v1" will never evaluates to 0 (due to the code above)
            decimal steps = (decimal)(x1 - x2) / (decimal)(v2 - v1); //Must perform casting to obtain a floating point answer (otherwise the result of the division may not be accurate for certain input, ex. 2932 7030 9106 4840)

            if (steps > 0 && (steps % 1 == 0))
                return "YES";
            else // steps < 0 or steps is not an integer
                return "NO";
        }

        static void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}
