using System;
using System.Collections;
using Task_3;

namespace Task_3
{
    class Program
    {
        public static void DefaultArray(int l)
        {
            ArrayList arr = new ArrayList(l);

            for (int i = 0; i < l; i++)
            {
                if (i % 3 == 0)
                {
                    arr.Add(3);
                }
                else if (i % 4 == 0)
                {   
                    arr.Add(4);
                }
                else if (i % 5 == 0)
                {
                    arr.Add(5);
                }
                else
                {
                    arr.Add(0);
                }
            }

            DateTime start = DateTime.Now;
            Array.Sort(arr.ToArray());
            DateTime finish = DateTime.Now;
            TimeSpan duration = finish - start;

            Console.WriteLine("Finished! Sort time : " + duration.ToString());
        }

        public static void TypedCollection(int l)
        {
            Material Cotton = new Material(50, 100, "Ukraine");
            Material Silk = new Material(90, 50, "Poland");

            Material[] forCoat = new Material[2];
            forCoat[0] = Cotton;
            forCoat[1] = Silk;

            Clothes Coat = new Clothes(forCoat, "Premium Coat", true);
            Clothes Jeens = new Clothes(forCoat, "Cool Jeens", false);
            Clothes Pants = new Clothes(forCoat, "Pants from hell", true);

            Clothes[] goods = new Clothes[l];

            for (int i = 0; i < l; i++)
            {
                if (i == 0 || i % 3 == 0)
                {
                    goods[i] = Coat;
                }
                else if (i == 1 || i % 4 == 0)
                {
                    goods[i] = Jeens;
                }
                else if (i == 2 || i % 5 == 0)
                {   
                    goods[i] = Pants;
                }
                else
                {
                    goods[i] = Coat;
                }
            }

            DateTime start = DateTime.Now;
            Array.Sort(goods);
            DateTime finish = DateTime.Now;
            TimeSpan duration = finish - start;

            Console.WriteLine("Finished! Sort time : " + duration.ToString());
        }

        public static void UntypedCollection(int l)
        {
            Stack<string>[] stringStack = new Stack<string>[l];

            for(int i = 0; i < l; i++)
            {
                stringStack[i] = new Stack<string>();
                if(i == 0 || i % 3 == 0)
                {
                    stringStack[i].Push("Molekula");
                }
                else if( i == 1 || i % 4 == 0)
                {
                    stringStack[i].Push("Atom");
                    stringStack[i].Push("Molekula");
                }
                else if( i == 2 || i % 5 == 0)
                {
                    stringStack[i].Push("Atom");
                    stringStack[i].Push("Molekula");
                }
                else
                {
                    stringStack[i].Push("Molekula");
                }

            }

            DateTime start = DateTime.Now;
            Array.Sort(stringStack);
            DateTime finish = DateTime.Now;
            TimeSpan duration = finish - start;

            Console.WriteLine("Sort time : " + duration.ToString());
        }

        static void Main(string[] args)
        {
            int[] elements = { 10, 50, 100, 200 };


            Console.WriteLine("Default array");
            Console.WriteLine("====================================================");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine("Elements count : " + elements[i].ToString());
                DefaultArray(elements[i]);
            }
            Console.WriteLine("====================================================\n");


            Console.WriteLine("Typed collection");
            Console.WriteLine("====================================================");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine("Elements count : " + elements[i].ToString());
                TypedCollection(elements[i]);
            }
            Console.WriteLine("====================================================\n");


            Console.WriteLine("Untyped collection");
            Console.WriteLine("====================================================");
            for(int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine("Elements count : " + elements[i].ToString());
                UntypedCollection(elements[i]);
            }
            Console.WriteLine("====================================================\n");
            



        }
    }
}
