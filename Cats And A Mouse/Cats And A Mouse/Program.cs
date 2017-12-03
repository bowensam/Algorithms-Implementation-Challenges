using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_And_A_Mouse
{
    class Program
    {
        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x[0]); //Cat A's position
                int y = Convert.ToInt32(tokens_x[1]); //Cat B's position
                int z = Convert.ToInt32(tokens_x[2]); //Mouse C's position

                if (Math.Abs(z - x) < Math.Abs(z - y)) //Cat A is closer to Mouse C
                    Console.WriteLine("Cat A");
                else if (Math.Abs(z - y) < Math.Abs(z - x)) //Cat B is closer to Mouse C
                    Console.WriteLine("Cat B");
                else //Cat A and Cat B are equidistant to Mouse C
                    Console.WriteLine("Mouse C");
            }
        }
    }
}
