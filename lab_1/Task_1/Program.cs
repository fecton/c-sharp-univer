using System.Diagnostics.CodeAnalysis;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Magenta;

            Console.Title = "Laba 01 by Fecton";

            Console.SetWindowSize(40, 40);

            Console.Beep();

            // Datetime
            Console.WriteLine(DateTime.Now);
            var birthday = new DateTime(2023, 4, 16);
            var a = 365 - DateTime.Now.DayOfYear + birthday.DayOfYear;
            Console.WriteLine("To birthday: " + Convert.ToString(a));
            var khai = new DateTime(2023, 8, 18);
            a = 365 - DateTime.Now.DayOfYear + khai.DayOfYear;
            Console.WriteLine("To Khai day: " + Convert.ToString(a));
            
            Console.WriteLine("To win: " + Convert.ToString(365 - DateTime.Now.DayOfYear));
        }
    }
}
