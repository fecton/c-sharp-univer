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

            Material[] forCoat = new Material[10];
            forCoat[0] = Cotton;
            forCoat[1] = Leather;
            int forCoat_length = 2;
            Material[] forJeens = new Material[10];
            forJeens[0] = Silk;
            forJeens[1] = Cotton;
            int forJeens_length = 2;


            Clothes Coat = new Clothes(forCoat, "Premium Coat", true);
            Clothes Jeens = new Clothes(forJeens, "Cool Jeens", false);
            Clothes[] goods = new Clothes[10];
            goods[0] = Coat;
            goods[1] = Jeens;
            int goods_length = 2;

            ClotherShop Guchi = new ClotherShop(goods, "Guchi", "Italy", 4234);

            Console.WriteLine("Clothers shop at the first time:");
            Guchi.Show();

            Console.WriteLine("Clothes shop created a cool thing!");
            Guchi.Add(Guchi.Clothes[0]);
            Guchi.Show();

            Console.WriteLine("A cool thing was bought by people!");
            Guchi.Delete();
            Guchi.Show();
        }
    }
}

