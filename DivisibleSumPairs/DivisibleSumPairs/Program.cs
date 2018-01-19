using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    class Solution
    {
        static void Main(string[] args)
        {
            String[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            String[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = DivisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }

        static int DivisibleSumPairs(int n, int k, int[] ar)
        {
            // Complete this function
            int numOfPair = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                { //Compare only with numbers beyond i-th index
                    if ((ar[i] + ar[j]) % k == 0)
                        numOfPair++;
                }
            }
            return numOfPair;
        }

    }
}
