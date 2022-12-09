namespace Task02
{
    public class City
    {
        // Властивості
        private string name;
        private int year_of_foundation;
        private int age;
        private string country;
        private static string nationality;

        // Static Constructor
        static City() => nationality = "Ukrainian";

        // Constructor #1
        public string Name
        {
            get => name;
            set => name = value;
        }

        // Constructor #2
        public int YearOfFoundation
        {
            get => year_of_foundation;
            set => year_of_foundation = value;
        }

        public int Age
        {
            get => getAge();
        }

        // Connstructor #3
        public string Country
        {
            get => country;
            set => country = value;
        }

        public City(string name, int year_of_foundation, string country)
        {
            Name = name;
            Country = country;
            YearOfFoundation = year_of_foundation;
        }

        // Get Age of the city
        public int getAge()
        {
            if(year_of_foundation < 0)
            {
                return 0;
            }
            return DateTime.Now.Year - year_of_foundation;
        }

        public string ToText()
        {
            return String.Format("The city {0} in {1} founded in {2} with {3} age is {4}", Name, Country, YearOfFoundation, DateTime.Now.Year - YearOfFoundation, nationality);
        }
    }
}
