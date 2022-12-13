using Newtonsoft.Json;
using System.IO.Enumeration;
using System.Net.Http.Json;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Json;

namespace Task_1
{
    internal class Program
    {
        public const string filename = "currency.json";

        static void WriteAll(List<Currency> instances, string file)
        {
            string serializedUsers = JsonConvert.SerializeObject(instances);
            
            File.WriteAllText(file, serializedUsers);
        }

        static List<Currency> ReadAll()
        {
            string json = File.ReadAllText(filename);

            List<Currency> instances = JsonConvert.DeserializeObject<List<Currency>>(json)!;

            return instances;
        }

        static public int GetLength(Currency[] arr)
        {
            int i = 0;
            while (arr[i] != null)
            {
                i++;
            }
            return i;
        }

        static public void menu()
        {
            Console.WriteLine("\t========== Menu ==========");
            Console.WriteLine("\t0. This menu"); // +
            Console.WriteLine("\t1. Show content"); // +
            Console.WriteLine("\t2. Add record"); // +
            Console.WriteLine("\t3. Delete record"); // +
            Console.WriteLine("\t4. Change record"); // +
            Console.WriteLine("\t5. Find record"); // +
            Console.WriteLine("\t6. Export to another file");
            Console.WriteLine("\t7. Save and exit");
            Console.WriteLine("\t8. Exit (without saving)"); // +
            Console.WriteLine("\t==========================");

        }

        public static void Main(string[] args)
        {
            List<Currency> array = ReadAll();

            // Infinity cycle or MENU
            int op = 0;
            int i = 0;
            char yn;
            int user_value;
            int field_id = 0;
            string value = "";
            Currency t = new Currency(0,0,0,0,0,0);
            while (true)
            {
                switch (op)
                {


                    // Prints menu
                    case 0:
                        menu();
                        break;


                    // Show structured file content
                    case 1:
                        i = 0;
                        foreach(Currency c in array)
                        {

                            Console.WriteLine(String.Format("==========={0}===========", i));
                            Console.WriteLine("CurrencyCodeA = " + c.currencyCodeA.ToString());
                            Console.WriteLine("CurrencyCodeB = " + c.currencyCodeB.ToString());
                            Console.WriteLine("Date = " + c.date.ToString());
                            if (c.rateCross == 0)
                            {
                                Console.WriteLine("RateBuy = " + c.rateBuy.ToString());
                                Console.WriteLine("RateSell = " + c.rateSell.ToString());
                            }
                            else
                            {
                                Console.WriteLine("RateCross = " + c.rateCross.ToString());
                            }
                            Console.WriteLine("============================\n");

                            i++;
                        }
                        Console.WriteLine("Totally: " + i.ToString());
                        break;


                    // Add record to array
                    case 2:
                        Console.WriteLine("\t[Add a record]");
                        Console.WriteLine("If you want to skip a field, enter: 0");

                        Console.Write("currencyCodeA = ");
                        t.currencyCodeA = int.Parse(Console.ReadLine());

                        Console.Write("currencyCodeB = ");
                        t.currencyCodeB = int.Parse(Console.ReadLine());

                        Console.Write("date = ");
                        t.date = int.Parse(Console.ReadLine());

                        Console.Write("rateBuy = ");
                        t.rateBuy = double.Parse(Console.ReadLine());

                        Console.Write("rateSell = ");
                        t.rateSell = double.Parse(Console.ReadLine());

                        Console.Write("rateCross = ");
                        t.rateCross = double.Parse(Console.ReadLine());

                        array.Add((Currency) t.Clone());

                        Console.WriteLine("[OK]");

                        break;

                    // Remove record in array
                    case 3:
                        Console.Write("[Enter a record index] >> ");
                        user_value = int.Parse(Console.ReadLine());

                        // numbers = numbers.Where((val, idx) => idx != numIndex).ToArray();
                        array.Remove(array[user_value]);

                        Console.WriteLine("[OK]");


                        break;

                    // Change record in array
                    case 4:
                        Console.Write("[Enter a record index] >> ");
                        user_value = int.Parse(Console.ReadLine());

                        t = array[user_value];

                        // Print object information
                        Console.WriteLine("===== [ INFO ] =====");
                        Console.WriteLine("1. CurrencyCodeA = " + t.currencyCodeA.ToString());
                        Console.WriteLine("2. CurrencyCodeB = " + t.currencyCodeB.ToString());
                        Console.WriteLine("3. Date = " + t.date.ToString());
                        if (t.rateCross == 0)
                        {
                            Console.WriteLine("4. RateBuy = " + t.rateBuy.ToString());
                            Console.WriteLine("5. RateSell = " + t.rateSell.ToString());
                        }
                        else
                        {
                            Console.WriteLine("4. RateCross = " + t.rateCross.ToString());
                        }
                        Console.WriteLine("=====================\n");


                        Console.Write("[Field's number] >> ");
                        field_id = int.Parse(Console.ReadLine());
                        Console.Write("[Field's value] >> ");
                        value = Console.ReadLine();

                        switch (field_id)
                        {
                            case 1:
                                t.currencyCodeA = int.Parse(value);
                                break;
                            case 2:
                                t.currencyCodeB = int.Parse(value);
                                break;
                            case 3:
                                t.date = int.Parse(value);
                                break;
                            case 4:
                                if (t.rateBuy == 0)
                                {
                                    t.rateCross = double.Parse(value);
                                }
                                else
                                {
                                    t.rateBuy = double.Parse(value);
                                }
                                break;
                            case 5:
                                if (t.rateSell == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    t.rateSell = double.Parse(value);
                                }
                                break;
                            default:
                                Console.WriteLine("[ERR] This field doesn't exist!");
                                break;
                        }

                        Console.WriteLine("[OK]");

                        break;

                    // Find record in array
                    case 5:
                        Console.WriteLine("Fields to search:");
                        Console.WriteLine("\t1. currencyCodeA");
                        Console.WriteLine("\t2. currencyCodeB");
                        Console.WriteLine("\t3. date");
                        Console.WriteLine("\t4. rateBuy");
                        Console.WriteLine("\t5. rateSell");
                        Console.WriteLine("\t6. rateCross");

                        Console.Write("[Field's number] >> ");
                        field_id = int.Parse(Console.ReadLine());

                        Console.Write("[Value to find] >> ");
                        value = Console.ReadLine();

                        bool flag = true;
                        i = 0;
                        foreach(Currency c in array)
                        {
                            if (!flag)
                            {
                                break;
                            }

                            switch (field_id)
                            {
                                // currencyCodeA
                                case 1:
                                    if (c.currencyCodeA == int.Parse(value))
                                    {
                                        flag = false;
                                    }
                                    break;

                                // currencyCodeB
                                case 2:
                                    if (c.currencyCodeB == int.Parse(value))
                                    {
                                        flag = false;
                                    }
                                    break;

                                // date
                                case 3:
                                    if (c.date == int.Parse(value))
                                    {
                                        flag = false;
                                    }
                                    break;

                                // rateBuy
                                case 4:
                                    if (c.rateBuy == double.Parse(value))
                                    {
                                        flag = false;
                                    }
                                    break;

                                // rateSell
                                case 5:
                                    if (c.rateSell == double.Parse(value))
                                    {
                                        flag = false;
                                    }
                                    break;

                                // rateCross
                                case 6:
                                    if (c.rateCross == double.Parse(value))
                                    {
                                        flag = false;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("[ERR] Invalid field's number!");
                                    break;
                            }


                            if (!flag)
                            {
                                Console.WriteLine();
                                Console.WriteLine(">>> [Found!] <<<<");
                                Console.WriteLine("Index: " + i.ToString());
                                Console.WriteLine("CurrencyCodeA = " + t.currencyCodeA.ToString());
                                Console.WriteLine("CurrencyCodeB = " + t.currencyCodeB.ToString());
                                Console.WriteLine("Date = " + t.date.ToString());
                                if (t.rateCross == 0)
                                {
                                    Console.WriteLine("RateBuy = " + t.rateBuy.ToString());
                                    Console.WriteLine("RateSell = " + t.rateSell.ToString());
                                }
                                else
                                {
                                    Console.WriteLine("RateCross = " + t.rateCross.ToString());
                                }
                                Console.WriteLine("\n");
                            }
                            i++;
                        }
                        if (flag)
                        {
                            Console.WriteLine("[ERR] 404 not found\n");
                        }

                        break;


                    // Export file content to another file
                    case 6:
                        Console.Write("Enteer filename to export: ");
                        value = Console.ReadLine();

                        WriteAll(array,value);
                        Console.WriteLine("OK");
                        break;


                    // Save data and exit
                    case 7:
                        // saving user data to currency.json
                        WriteAll(array, filename);
                        Console.WriteLine("Ok");
                        return;
                        


                    // Just exit without saving the file
                    case 8:
                        Console.Write("[INFO] You may lost of your data. Are you sure? (y/N): ");
                        yn = Console.ReadLine()[0];

                        if (yn == 'y')
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("[INFO] Your data was saved from destruction! :)");
                        }

                        break;
                    default:
                        Console.WriteLine("[INFO] Invalid operation!");
                        break;
                }
                Console.Write("[OP] >> ");
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("[ERR] Invalid format!");
                    op = 0;
                }
            }

            return;
        }
    }
}