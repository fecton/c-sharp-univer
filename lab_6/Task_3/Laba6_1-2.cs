using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Stack<T> : IComparable<Stack<T>>
    {

        int index = 0;
        T[] innerArray = new T[5000000];
        public void Push(T item)
        {
            innerArray[index++] = item;
        }
        public T Pop()
        {
            return innerArray[--index];
        }

        public T Get(int k)
        {
            return innerArray[k];
        }

        public bool IsElementHere(T el)
        {
            return innerArray.Contains(el);
        }

        public void Show()
        {
            for (int i = 0; i < Length(); i++)
            {
                Console.WriteLine(i.ToString() + " : " + innerArray[i]);
            }
            Console.WriteLine();
        }

        public int Length()
        {
            return innerArray.Count(s => s != null);
        }

        public int CompareTo(Stack<T> other)
        {
            return Length().CompareTo(other.Length());
        }
    }

    class Methods<T>
    {
        // Виведення всього масиву
        public static void PrintArray(Stack<T>[] list, int length)
        {
            Console.WriteLine("Printing array\n");

            for (int i = 0; i < length; i++)
            {
                list[i].Show();
            }

        }

        // Знаходження кількості колекцій, що містять вказаний елемент
        public static int ElementsCount(T el, Stack<T>[] list, int length)
        {
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                if (list[i].IsElementHere(el))
                {
                    count++;
                }
            }

            return count;
        }

        // Знаходження кількості максимальної колекції, що містить вказаний елемент
        public static void MaxCollection(T el, Stack<T>[] list, int length)
        {
            int maxlength = 0;
            Stack<T> tmp = new Stack<T>();

            for (int i = 0; i < length; i++)
            {
                if (list[i].IsElementHere(el) && maxlength < list[i].Length())
                {
                    tmp = list[i];
                    maxlength = list[i].Length();
                }
            }

            Console.WriteLine("Max stack is : ");
            tmp.Show();

            Console.WriteLine("With length : " + maxlength.ToString());
        }
    }
}
