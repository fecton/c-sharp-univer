using Task02;

namespace Taask02_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City Kharkiv = new City("Kharkiv", 1654, "Ukraine");
            Kharkiv.Name = "Kharkiv";
            Kharkiv.Country = "Ukraine";
            Kharkiv.YearOfFoundation = 1654;

            Console.WriteLine(Kharkiv.Name);
            Console.WriteLine(Kharkiv.Age);
            Console.WriteLine(Kharkiv.YearOfFoundation);

            Console.WriteLine(Kharkiv.ToText());
        }
    }
}
