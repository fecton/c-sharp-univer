using Task02;

namespace Taask02_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City Kharkiv = new City();
            Kharkiv.setName("Kharkiv");
            Kharkiv.setCountry("Ukraine");
            Kharkiv.setYearOFF(1654);
            Kharkiv.setSymbol('K');

            Console.WriteLine(Kharkiv.getName());
            Console.WriteLine(Kharkiv.getAge());
            Console.WriteLine(Kharkiv.getYearOFF());
            Console.WriteLine(Kharkiv.getSymbol());

            Console.WriteLine(Kharkiv.ToText());
        }
    }
}

