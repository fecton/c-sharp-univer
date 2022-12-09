using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task_2
{

    // Клас джерело-події: каталог товарів
    // Подія: додавання нового товару
    // Клас-підписник: список бажань
    // Реація на подію: повідомлення, якщо додано товар до списку бажань
    public class Catalog_of_goods
    {

        public delegate void AccountHandler(string message);
        public event AccountHandler? Notify;
        List<string> goods = new List<string>();

        public void Add(string a)
        {
            goods.Add(a);
            Notify?.Invoke($"Hoba, your '{a}' was added to your favorities!");
        }

        public void Show()
        {
            for(int i=0; i < goods.Count; i++)
            {
                Console.WriteLine(" - " + goods[i]);
            }
            Console.WriteLine();
        }

    }
}
