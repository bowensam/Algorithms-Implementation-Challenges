using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = p.sockMerchant(n, ar);
            Console.WriteLine(result);
        }

        private int sockMerchant(int n, int[] ar)
        {
            // Complete this function
            Array.Sort(ar);
            int pair = 0;

            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] == ar[i + 1])
                {
                    pair++;
                    i++;
                }
            }
            return pair;
        }
    }
}
