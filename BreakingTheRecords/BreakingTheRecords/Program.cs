using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(String[] args)
        {
            Program p = new Program();
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = p.getRecord(s);
            Console.WriteLine(String.Join(" ", result));
        }

        private int[] getRecord(int[] s)
        {
            // Complete this function
            int highestRecord = s[0];
            int highestCount = 0;
            int lowestRecord = s[0];
            int lowestCount = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] > highestRecord)
                {
                    highestRecord = s[i];
                    highestCount++;
                }
                if (s[i] < lowestRecord)
                {
                    lowestRecord = s[i];
                    lowestCount++;
                }
            }
            int[] result = { highestCount, lowestCount };
            return result;
        }
    }
}
