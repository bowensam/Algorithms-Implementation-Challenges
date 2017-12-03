using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = Solve(grades);
            Console.WriteLine(String.Join("\n", result));
        }

        static int[] Solve(int[] grades)
        {
            // Complete this function
            for (int grade = 0; grade < grades.Length; grade++)
            {
                if ((grades[grade] >= 38) && (grades[grade] % 5 != 0)) //Eligible for rounding
                    grades[grade] = Rounding(grades[grade]);
            }
            return grades;
        }
        private static int Rounding(int grade)
        {
            if ((grade + 1) % 5 == 0) //Grade ending in 4, 9
                return grade + 1;
            else if ((grade + 2) % 5 == 0) //Grade ending in 3, 8
                return grade + 2;
            else //Grade ending in 1, 2, 6, 7 (No rounding)
                return grade;
        }
    }
}
