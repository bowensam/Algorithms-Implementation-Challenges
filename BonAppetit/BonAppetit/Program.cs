using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int b = Convert.ToInt32(Console.ReadLine());
            String result = BonAppetit(n, k, b, ar);
            Console.WriteLine(result);
        }

        static String BonAppetit(int n, int k, int b, int[] ar)
        {
            // Complete this function
            int total = 0;
            for (int dish = 0; dish < ar.Length; dish++)
                total += ar[dish];

            int b_actual = (total - ar[k]) / 2;

            if (b_actual - b == 0)
                return "Bon Appetit";
            else
                return (Math.Abs(b_actual - b)).ToString();
        }
    }
}
