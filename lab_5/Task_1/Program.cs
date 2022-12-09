using Laba05;
using System;

delegate string Delegate(string a, int b);
class Program
{
    static void TEST_CLASS_1()
    {
        string[] test_strings = { "Bislovodsk", "Upkraine", "Luhanstk", "1Donetsk" };
        int[] test_index = { 2, 1, 6, 0 };
        string[] test_results = { "Bilovodsk", "Ukraine", "Luhansk", "Donetsk" };

        string func_answer;

        Console.WriteLine("[TESTS CLASS 1: RemoveSymbol]");
        for(int test = 0; test < test_strings.Length; test++)
        {
            func_answer = Class1.RemoveSymbol(test_strings[test], test_index[test]);

            if(func_answer == test_results[test])
            {
                Console.WriteLine("[SUCCESS]");
            }
            else
            {
                Console.WriteLine("[FAILED] Got: '{0}', Expected: '{1}'", func_answer, test_results[test]);
            }
        }
        Console.WriteLine();


        Console.WriteLine("[TESTS CLASS 1: ReplaceSymbols]");

        string[] tests_strings2 = { "Soviet Ukraine", "word1 word2", "HomeWork is coming" };
        int[] tests_n = { 7, 5, 4 };
        string[] tests_results2 = { "*******Ukraine", "***** word2", "****Work is coming"};

        for (int test = 0; test < tests_strings2.Length; test++)
        {
            func_answer = Class1.ReplaceSymbols(tests_strings2[test], tests_n[test]);

            if (func_answer == tests_results2[test])
            {
                Console.WriteLine("[SUCCESS]");
            }
            else
            {
                Console.WriteLine("[FAILED] Got: '{0}', Expected: '{1}'", func_answer, tests_results2[test]);
            }
        }
        Console.WriteLine();
    }

    static void TEST_CLASS_2()
    {
        Console.WriteLine("[TESTS CLASS 2: SubString]");

        string[] test_strings = { "Soviet Ukrainian Republic", "I like drinking kvas", "There are very interesting texts, aren't it?" };
        int[] k_index = { 7, 7, 15};
        string[] results = { "Ukrainian Republic", "drinking kvas", "interesting texts, aren't it?" };

        string func_answer;

        for (int test = 0; test < test_strings.Length; test++)
        {
            func_answer = Class2.SubString(test_strings[test], k_index[test]);

            if (func_answer == results[test])
            {
                Console.WriteLine("[SUCCESS]");
            }
            else
            {
                Console.WriteLine("[FAILED] Got: '{0}', Expected: '{1}'", func_answer, results[test]);
            }
        }
        Console.WriteLine();
    }

    

    static void Main(string[] args)
    {
        Console.WriteLine("Tests 1");
        TEST_CLASS_1();

        Console.WriteLine("Tests 2");
        TEST_CLASS_2();

        string example = "This is a super cool text";
        int n = 10;
        string res;

        Delegate d;
        d = Class1.RemoveSymbol;

        Console.WriteLine("Remove symbol");
        res = d(example, n);
        Console.WriteLine(res+"\n");

        Console.WriteLine("Replace symbols");
        d = Class1.ReplaceSymbols;
        res = d(example, n);
        Console.WriteLine(res + "\n");

        Console.WriteLine("Sub string");
        d = Class2.SubString;
        res = d(example, n);
        Console.WriteLine(res + "\n");

    }
}

