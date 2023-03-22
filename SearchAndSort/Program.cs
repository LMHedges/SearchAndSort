using System;

namespace SearchAndSort
{
    class Program
    {
        private static void SortMenu()
        {
            string input1 = string.Empty;
            string input2;
            bool valid = true;
            while(valid == true)
            {
                Console.WriteLine("1. Ascending");
                Console.WriteLine("2. Descending");
                input1 = Console.ReadLine();
                if(input1 == "1" || input1 == "2")
                {
                    valid = false;
                }
                else
                {
                    Console.WriteLine("Please enter 1 or 2");
                }
            }
            valid = true;
            while (valid == true)
            {
                Console.WriteLine("1. Road_1_256");
                Console.WriteLine("2. Road_2_256");
                Console.WriteLine("3. Road_3_256");
                Console.WriteLine("4. Road_1_2048");
                Console.WriteLine("5. Road_2_2048");
                Console.WriteLine("6. Road_3_2048");
                input2 = Console.ReadLine();
                switch (input2)
                {
                    case "1":
                        Roads.Road1 = Sort.Order(input1, Roads.Road1, true);
                        Roads.Sort1 = true;
                        valid = false;
                        break;
                    case "2":
                        Roads.Road2 = Sort.Order(input1, Roads.Road2, true);
                        Roads.Sort2 = true;
                        valid = false;
                        break;
                    case "3":
                        Roads.Road3 = Sort.Order(input1, Roads.Road3, true);
                        Roads.Sort3 = true;
                        valid = false;
                        break;
                    case "4":
                        Roads.Road4 = Sort.Order(input1, Roads.Road4, false);
                        Roads.Sort4 = true;
                        valid = false;
                        break;
                    case "5":
                        Roads.Road5 = Sort.Order(input1, Roads.Road5, false);
                        Roads.Sort5 = true;
                        valid = false;
                        break;
                    case "6":
                        Roads.Road6 = Sort.Order(input1, Roads.Road6, false);
                        Roads.Sort6 = true;
                        valid = false;
                        break;
                    default:
                        Console.WriteLine("Please enter 1, 2, 3, 4, 5 or 6");
                        break;
                }
            }
        }
        private static void SearchMenu()
        {
            bool valid = true;
            int input1 = 0;
            string input2;
            while (valid == true)
            {
                Console.Write("Please enter the value your looking for: ");
                try
                {
                    input1 = int.Parse(Console.ReadLine());
                    valid = false;
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }

            }
            valid = true;
            while(valid == true)
            {
                Console.WriteLine("1. Road_1_256");
                Console.WriteLine("2. Road_2_256");
                Console.WriteLine("3. Road_3_256");
                Console.WriteLine("4. Road_1_2048");
                Console.WriteLine("5. Road_2_2048");
                Console.WriteLine("6. Road_3_2048");
                input2 = Console.ReadLine();
                switch (input2)
                {
                    case "1":
                        Search.Find(input1, input2, Roads.Road1);
                        valid = false;
                        break;
                    case "2":
                        Search.Find(input1, input2, Roads.Road2);
                        valid = false;
                        break;
                    case "3":
                        Search.Find(input1, input2, Roads.Road3);
                        valid = false;
                        break;
                    case "4":
                        Search.Find(input1, input2, Roads.Road4);
                        valid = false;
                        break;
                    case "5":
                        Search.Find(input1, input2, Roads.Road5);
                        valid = false;
                        break;
                    case "6":
                        Search.Find(input1, input2, Roads.Road6);
                        valid = false;
                        break;
                    default:
                        Console.WriteLine("Please enter 1, 2, 3, 4, 5 or 6");
                        break;
                }
            }
        }
        private static void MergeMenu()
        {
            string input = string.Empty;
            bool valid = true;
            while (valid == true)
            {
                Console.WriteLine("1. Merge small");
                Console.WriteLine("2. Merge large");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Merge.Small();
                    valid = false;
                }
                else if(input == "2")
                {
                    Merge.Large();
                    valid = false;
                }
                else
                {
                    Console.WriteLine("Please enter 1 or 2");
                }
            }
        }
        static void Main(string[] args)
        {
            new Roads();
            bool valid = true;
            string input;
            while(valid == true)
            {
                Console.WriteLine("1. Sort");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Merge");
                Console.WriteLine("3. Quit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        SortMenu();
                        break;
                    case "2": 
                        SearchMenu();
                        break;
                    case "3":
                        MergeMenu();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye");
                        valid = false;
                        break;
                    default:
                        Console.WriteLine("Please enter 1, 2 or 3");
                        break;
                }

            }
        }
    }
}
