using System.Text.RegularExpressions;

namespace Task_2
{
    internal class Program
    {
        static public void help()
        {
            Console.WriteLine("Task 2 made by Andrii Lytvynenko (C) 2022" +
                "\n\t - /s -- search in a list of words" +
                "\n\t - /f -- search in a list of files" +
                "\n\t - /? /h -- this help message");
        }

        public static void Main(string[] args)
        {
            string pattern = @"(\(050\)\d{3}-\d{2}-\d{2})|(097\d{7})|(073-\d{3}-\d{2}-\d{2})";
            string argument;
            string tmp = "";

            try
            {
                argument = args[0];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("[ERR] No command and values!");
                return;
            }

            List<string> values = args.ToList();
            values = values.GetRange(1, values.Count-1);

            if(values.Count == 0 && !(argument == "/?" || argument == "/h"))
            {
                // user must enter values
                Console.WriteLine("Enter values. If you want to exit, you'll enter 'end' key :)");
                while(true)
                {
                    tmp = Console.ReadLine()!;
                    
                    if(tmp == "end")
                    {
                        break;
                    }
                    
                    values.Add(tmp);
                }
            }


            Console.WriteLine("\n======= Regex check begins! =======\n");

            switch (argument)
            {
                case "/s":
                    foreach(string word in values)
                    {
                        if(Regex.IsMatch(word, pattern))
                        {
                            Console.WriteLine(String.Format("'{0}' is good! :)", word));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("'{0}' is BAAAAAAD! >:(", word));
                        }
                    }
                    break;

                case "/f":
                    foreach(string file in values)
                    {
                        try
                        {
                            string[] text = File.ReadAllLines(file);
                            foreach (string word in text)
                            {
                                if (Regex.IsMatch(word, pattern))
                                {
                                    Console.WriteLine(String.Format("'{0}' is good! :)", word));
                                }
                                else
                                {
                                    Console.WriteLine(String.Format("'{0}' is BAAAAAAD! >:(", word));
                                }
                            }
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine(String.Format("[ERR] '{0}' not found!", file));
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("[ERR] Empty filename!");
                        }
                    }
                    break;

                case "/?":
                case "/h":
                    help();
                    break;
            }



            return;
        }
    }
}