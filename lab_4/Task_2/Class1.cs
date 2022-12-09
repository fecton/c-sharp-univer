namespace Task_2_1
{
    internal class Task_2_1
    {
        static void Main(string[] args)
        {
            // input data

            string name;
            int YOF;
            int money;
            int popularity;

            Console.WriteLine("Enter name: ");
            name     = Console.ReadLine();


            Locality Markivka = new Locality(name);


            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter year of foundation: ");
            YOF = int.Parse(Console.ReadLine());

            Village Bilokyrakina = new Village(name, YOF);



            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter year of foundation: ");
            YOF = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter popularity: ");
            popularity = int.Parse(Console.ReadLine());

            Urban_village Bilovodsk = new Urban_village(name, YOF, popularity);

            Locality[] cities = { Markivka, Bilokyrakina, Bilovodsk };


            Village tmpV;
            Urban_village tmpUV;


            Console.WriteLine("\n\n");
            for(int i = 0; i < 3; ++i)
            {
                if(i == 0)
                {
                    Console.WriteLine("<LOCATION> Name: " + cities[i].Name);
                }
                else if (i == 1)
                {
                    tmpV = (Village)cities[i];
                    Console.WriteLine("<VILLAGE> Name: " + tmpV.Name + "\nYear of foundation: " + tmpV.YOF);
                }
                else if(i == 2)
                {
                    tmpUV = (Urban_village)cities[i];
                    Console.WriteLine("<URBAN VILLAGE> Name: " + tmpUV.Name + "\nYear of foundation: " + tmpUV.YOF + "\nPopularity: " + tmpUV.Popularity);
                }
            }

        }
    }
}

