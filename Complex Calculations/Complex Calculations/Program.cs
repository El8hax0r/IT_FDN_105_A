using System;

namespace Complex_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Seconds: ");
            string sSeconds = Console.ReadLine();
            int iSeconds = int.Parse(sSeconds);

            int iDays = iSeconds / 86400; //seconds per day
            iSeconds = iSeconds % 86400; //remainder

            int iHours = iSeconds / 3600; //seconds per hour
            iSeconds = iSeconds % 3600;

            int iMinutes = iSeconds / 60; //seconds in one minute
            iSeconds = iSeconds % 60;

            Console.Write(sSeconds + "s = " + iDays.ToString() + " days, " + iHours.ToString() + " hours, " + iMinutes.ToString() + " minutes, and " + iSeconds.ToString() + " seconds");

            Console.Write("\n\nPress any key to exit...");

            Console.ReadKey();
        }
    }
}//testtest
