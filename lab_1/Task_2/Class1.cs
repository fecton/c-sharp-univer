namespace Task02
{
    public class City
    {
        private string name;
        private int year_of_foundation;
        private int age;
        private string country;
        private char symbol;

        public char getSymbol()
        {
            return symbol;
        }

        public string getName()
        {
            return name;
        }
        public int getYearOFF()
        {
            return year_of_foundation;
        }
        public int getAge()
        {
            if(year_of_foundation < 0)
            {
                return 0;
            }
            return DateTime.Now.Year - year_of_foundation;
        }
        public string getCountry()
        {
            return country;
        }

        public void setName(string newname)
        {
            name = newname;
            Console.WriteLine("New city name: " + newname);
        }
        public void setYearOFF(int newyearoff)
        {
            if(newyearoff < 0)
            {
                Console.WriteLine("Negative number");
            }
            else
            {
                year_of_foundation = newyearoff;
                Console.WriteLine("New year of foundation: " + year_of_foundation);
            }
        }
        public void setCountry(string newcountry)
        {
            country = newcountry;
            Console.WriteLine("New country: " + country);
        }

        public void setSymbol(char newsymbol)
        {
            symbol = newsymbol;
        }

        public string ToText()
        {
            return String.Format("The city {0} in {1} founded in {2} with {3} age with symbol '{4}'", name, country, year_of_foundation, DateTime.Now.Year - year_of_foundation, symbol);
        }
    }
}
