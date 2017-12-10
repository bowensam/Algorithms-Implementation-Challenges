using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            String word = Console.ReadLine();

            Console.WriteLine(word.Length * p.findTallestLetterHeight(h, word));
        }

        private int findTallestLetterHeight(int[] h, String word)
        {
            int tallestHeight = 0; //Based on the problem scenario, this method will never return 0
            for (int letter = 0; letter < word.Length; letter++)
            {
                if (tallestHeight < h[(int)word[letter] - 97])
                    tallestHeight = h[(int)word[letter] - 97];
            }
            return tallestHeight;
        }
    }
}
