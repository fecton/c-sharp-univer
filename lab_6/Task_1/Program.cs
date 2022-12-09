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
}

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Task 1");

        Stack<int> intStack = new Stack<int>();
        Stack<string> stringStack = new Stack<string>();


        Console.WriteLine("\n< Int stack >");

        intStack.Push(5);
        intStack.Push(4);
        intStack.Push(3);
        intStack.Push(2);
        intStack.Push(1);
        for(int i = 0; i <= 4; i++)
        {
            Console.WriteLine(i.ToString() + " : " + intStack.Get(i));
        }

        Console.WriteLine("\n< String stack >");
        stringStack.Push("Atom");
        stringStack.Push("Molekula");
        stringStack.Push("Element");
        stringStack.Push("Object");
        stringStack.Push("Planet");

        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine(i.ToString() + " : " + stringStack.Get(i));
        }

    }
}

