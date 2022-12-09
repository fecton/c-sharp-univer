using System;

using System;

class Stack<T>
{

    int index = 0;
    T[] innerArray = new T[100];
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
        for(int i = 0; i < Length(); i++)
        {
            Console.WriteLine(i.ToString() + " : " + innerArray[i]);
        }
        Console.WriteLine();
    }

    public int Length()
    {
        return innerArray.Count(s => s != null);
    }
}

class Methods<T>
{
    // Виведення всього масиву
    public static void PrintArray(Stack<T>[] list, int length)
    {
        Console.WriteLine("Printing array\n");

        for(int i = 0; i < length; i++)
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


class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Task 2");

        Stack<string>[] stringStack = new Stack<string> [10];

        stringStack[0] = new Stack<string>();
        stringStack[1] = new Stack<string>();
        stringStack[2] = new Stack<string>();

        int l = stringStack.Count(s => s != null);

        stringStack[0].Push("Atom");
        stringStack[0].Push("Molekula");
        stringStack[0].Push("Element");
        stringStack[0].Push("Object");

        stringStack[1].Push("Atom");
        stringStack[1].Push("Molekula");
        stringStack[1].Push("Object");
        stringStack[1].Push("Planet");

        stringStack[2].Push("Atom");
        stringStack[2].Push("Molekula");
        stringStack[2].Push("Object");
        stringStack[2].Push("Planet");

        for(int i = 0; i < l; i++)
        {
            Console.WriteLine("< Stack " + i.ToString() + " >");
            stringStack[i].Show();
        }


        Console.WriteLine("Element 'Planet' : " + Methods<string>.ElementsCount("Planet", stringStack, l).ToString());
        Console.WriteLine("Element 'Element' : " + Methods<string>.ElementsCount("Element", stringStack, l).ToString());
        Console.WriteLine("Element 'Atom' : " + Methods<string>.ElementsCount("Atom", stringStack, l).ToString());

        Console.WriteLine();

        Methods<string>.MaxCollection("Element", stringStack, 3);

    }
}