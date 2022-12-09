using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class Locality
    {
        public Locality(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }

    class Village : Locality
    {
        public Village(string name, int year_of_foundation) :base(name){

            if (year_of_foundation > 0 && year_of_foundation < 2023)
            {
                YOF = year_of_foundation;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public int YOF { get; set; }
    }


    class Urban_village : Village
    {
        public Urban_village(string name, int year_of_foundation, int popularity) : base(name, year_of_foundation)
        {
            if(popularity >= -100 && popularity <= 100)
            {
                Popularity = popularity;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int Popularity { get; set; }
    }

}

