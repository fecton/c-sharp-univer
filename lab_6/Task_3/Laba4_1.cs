using System.Data;

namespace Task_3
{
    public class Clothes : IComparable<Clothes>
    {
        public Clothes(Material[] materials, string clothesName, bool isFashion)
        {
            Materials = materials;
            ClothesName = clothesName;
            IsFashion = isFashion;
        }

        public Material[] Materials { get; set; }
        public string ClothesName { get; set; }
        public bool IsFashion { get; set; }

        public int CompareTo(Clothes other)
        {
            return ClothesName.CompareTo(other.ClothesName);
        }

    }

    public class Material : IComparable<Material>
    {
        public Material(int price, int quality, string country)
        {
            Price = price;
            Quality = quality;
            Country = country;
        }

        public int Price { get; set; }
        public int Quality { get; set; }
        public string Country { get; set; }

        public int CompareTo(Material other)
        {
            return Price.CompareTo(other.Price);
        }
    }

    public class ClotherShop
    {
        public ClotherShop(Clothes[] clothes, string name, string country, int costs)
        {
            Clothes = clothes;
            Name = name;
            Country = country;
            this.costs = costs;
        }

        public int Len()
        {
            int length = 0;
            for (int i = 0; i < Clothes.Length; i++)
            {
                if (Clothes[i] == null)
                {
                    break;
                }
                length++;
            }
            return length;
        }

        public void Add(Clothes obj)
        {
            Clothes[Len()] = obj;
        }

        public void Delete()
        {
            Clothes[Len() - 1] = null;
        }

        public void Show()
        {
            // define length
            for (int i = 0; i < Clothes.Length; ++i)
            {
                if (Clothes[i] == null)
                {
                    break;
                }
                Console.Write(Clothes[i].ClothesName + "\n");
            }
            Console.WriteLine();
        }

        public Clothes[] Clothes { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int costs { get; set; }
    }
}
