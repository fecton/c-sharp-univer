using Task02;

namespace Task02_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Material Cotton = new Material(50, 100, "Ukraine");
            Material Silk = new Material(90, 50, "Poland");
            Material Leather = new Material(100, 100, "USA");

            Material[] forCoat = new Material[3];
            forCoat[0] = Cotton;
            forCoat[1] = Leather;
            forCoat[2] = Silk;



            Material[] forJeens = new Material[2];
            forJeens[0] = Silk;
            forJeens[1] = Cotton;


            Clothes Coat = new Clothes(forCoat, "Premium Coat", true);
            Clothes Jeens = new Clothes(forJeens, "Cool Jeens", false);
            Clothes Pants = new Clothes(forJeens, "Pants from hell", true);
            Clothes[] goods = new Clothes[3];
            goods[0] = Coat;
            goods[1] = Jeens;
            goods[2] = Pants;

            Console.WriteLine("Unsorted array: ");
            foreach (Material item in Jeens.Materials)
            {
                Console.WriteLine(item.Price);
            }
            Console.WriteLine();
            Array.Sort(Jeens.Materials);
            Console.WriteLine("Sorted array: ");
            foreach (Material item in Jeens.Materials)
            {
                Console.WriteLine(item.Price);
            }
            Console.WriteLine();

            Console.WriteLine("Unsorted array: ");
            foreach (Clothes item in goods)
            {
                Console.WriteLine(item.ClothesName);
            }
            Console.WriteLine();

            Array.Sort(goods);

            Console.WriteLine("Sorted array: ");
            foreach (Clothes item in goods)
            {
                Console.WriteLine(item.ClothesName);
            }
            Console.WriteLine();

        }
    }
}
