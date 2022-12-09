using System;
using Task_2;

class Program
{
    static void Main(string[] args)
    {
        // Клас джерело-події: каталог товарів
        // Подія: додавання нового товару
        // Клас-підписник: список бажань
        // Реація на подію: повідомлення, якщо додано товар до списку бажань

        void DisplayMessage(string value)
        {
            Console.WriteLine(value + "\n");
        }

        Catalog_of_goods favorities = new Catalog_of_goods();

        favorities.Notify += DisplayMessage;

        string[] shoplist = { "Potato", "Coat", "Water", "Gas", "Mouse", "Phone", "Book" };

        int op = 0;

        for(int i = 0; i < shoplist.Length; i++)
        {
            Console.WriteLine("Current good: " + shoplist[i]);
            Console.Write("Select the action 0/1 (skip/add): ");
            op = Int32.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    favorities.Add(shoplist[i]);
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        }


        Console.WriteLine("Your favorite list: ");
        favorities.Show();


    }
}