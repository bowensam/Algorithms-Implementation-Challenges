using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    class Program
    {
        static void Main(String[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string result = Solve(year);
            Console.WriteLine(result);
        }

        static string Solve(int year)
        {
            // Complete this function
            Program sol = new Program();
            int[] daysArray;
            String[] programmingDate;

            if (1700 <= year && year <= 1917) //Julian Calendar
                daysArray = sol.MakeDaysArray(sol.DetermineLeap(year, 1), false);

            else if (year == 1918) //Julian-Georgian Calendar (Special Case)
                daysArray = sol.MakeDaysArray(false, true); //1918 is NOT a leap year

            else // 1919-2700 => Georgian Calendar
                daysArray = sol.MakeDaysArray(sol.DetermineLeap(year, 2), false);

            programmingDate = sol.FindProgrammingDayMonth(daysArray);

            return programmingDate[1] + "." + programmingDate[0] + "." + year;
        }

        private Boolean DetermineLeap(int year, byte calendarType)
        {
            // Note:    If calendarType = 1, Julian Calendar;
            //          If calendarType = 2, Georgian Calendar
            //          Don't need to consider Special Case, because 1918 is not a leap year in either calendar

            if (calendarType == 1)
            { //Julian
                if (year % 4 == 0)
                    return true;
                else
                    return false;
            }
            else
            { //Georgian
                if ((year % 4 == 0) && (year % 100 != 0))
                    return true;
                else if (year % 400 == 0)
                    return true;
                else
                    return false;
            }
        }

        private int[] MakeDaysArray(Boolean isLeap, Boolean specialCase)
        {
            if (specialCase)
            {
                int[] daysArray = { 31, 15, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                return daysArray;
            }
            else
            {
                if (isLeap)
                { //Leap year
                    int[] daysArray = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    return daysArray;
                }
                else
                { //Not leap year
                    int[] daysArray = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    return daysArray;
                }
            }
        }

        private String[] FindProgrammingDayMonth(int[] daysArray)
        {
            //programmingDate[0] = Month
            //programmingDate[1] = Day

            int dayCounter = 0;
            String[] programmingDate = new String[2];
            int theDay = 256;

            for (int i = 0; i < daysArray.Length; i++)
            {
                if ((theDay - daysArray[i]) >= 0)
                    theDay -= daysArray[i];

                else
                { //theDay - daysArray[i] < 0
                    programmingDate[0] = (i + 1).ToString();
                    programmingDate[1] = theDay.ToString();

                    if (Convert.ToInt32(programmingDate[0]) < 10)
                        programmingDate[0] = '0' + programmingDate[0];

                    if (Convert.ToInt32(programmingDate[1]) < 10)
                        programmingDate[1] = '0' + programmingDate[1].ToString();

                    return programmingDate;
                }
            }

            return programmingDate;
        }       
    }
}
