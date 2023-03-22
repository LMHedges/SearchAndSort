using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSort
{
    class Search
    {
        private static void Binary(int num, int low, int up, int[] road)
        {
            int mid;
            decimal temp;
            bool valid = true;
            while (valid == true && low <= up)
            {
                temp = low + ((up - low) / 2);
                temp = Math.Floor(temp);
                mid = decimal.ToInt32(temp);
                if (road[mid] == num)
                {
                    Console.WriteLine(num + " is found on line " + mid);
                    Binary(num, low, mid - 1, road);
                    Binary(num, mid + 1, up, road);
                    valid = false;
                }
                else if (road[mid] < num)
                {
                    low = mid + 1;
                }
                else
                {
                    up = mid - 1;
                }
            }
        }
        public static void Find(int num, string roadnum, int[] road)
        {
            switch (roadnum)
            {
                case "1":
                    if(Roads.Sort1 == true) //binary search
                    {
                        int mid = 0;
                        int low = 0;
                        decimal temp;
                        int up = road.Length - 1;
                        bool valid = true;
                        while(valid == true && low <= up)
                        {
                            temp = low + ((up - low) / 2);
                            temp = Math.Floor(temp);
                            mid = decimal.ToInt32(temp);
                            if (road[mid] == num)
                            {
                                Console.WriteLine(num + " is found on line " + mid);
                                Binary(num, low, mid - 1, road);
                                Binary(num, mid + 1, up, road);
                                valid = false;
                            }
                            else if(road[mid] < num)
                            {
                                low = mid + 1;
                            }
                            else
                            {
                                up = mid - 1;
                            }
                        }
                    }
                    else //linear search
                    {
                        bool check = false;
                        for (int i = 0; i < road.Length; i++)
                        {
                            if (road[i] == num)
                            {
                                Console.WriteLine(num + " is found on line " + i);
                                check = true;
                            }
                        }
                        if (check == false)
                        {
                            Console.WriteLine("Number not found");
                        }
                    }
                    break;
                case "2":
                    if (Roads.Sort2 == true)
                    {
                        int mid = 0;
                        int low = 0;
                        decimal temp;
                        int up = road.Length - 1;
                        bool valid = true;
                        while (valid == true && low <= up)
                        {
                            temp = low + ((up - low) / 2);
                            temp = Math.Floor(temp);
                            mid = decimal.ToInt32(temp);
                            if (road[mid] == num)
                            {
                                Console.WriteLine(num + " is found on line " + mid);
                                Binary(num, low, mid - 1, road);
                                Binary(num, mid + 1, up, road);
                                valid = false;
                            }
                            else if (road[mid] < num)
                            {
                                low = mid + 1;
                            }
                            else
                            {
                                up = mid - 1;
                            }
                            if (valid == false)
                            {
                                Console.WriteLine("Number not found");
                            }
                        }
                    }
                    else
                    {
                        bool check = false;
                        for (int i = 0; i < road.Length; i++)
                        {
                            if (road[i] == num)
                            {
                                Console.WriteLine(num + " is found on line " + i);
                                check = true;
                            }
                        }
                        if (check == false)
                        {
                            Console.WriteLine("Number not found");
                        }
                    }
                    break;
                case "3":
                    if (Roads.Sort3 == true)
                    {
                        int mid = 0;
                        int low = 0;
                        decimal temp;
                        int up = road.Length - 1;
                        bool valid = true;
                        while (valid == true && low <= up)
                        {
                            temp = low + ((up - low) / 2);
                            temp = Math.Floor(temp);
                            mid = decimal.ToInt32(temp);
                            if (road[mid] == num)
                            {
                                Console.WriteLine(num + " is found on line " + mid);
                                Binary(num, low, mid - 1, road);
                                Binary(num, mid + 1, up, road);
                                valid = false;
                            }
                            else if (road[mid] < num)
                            {
                                low = mid + 1;
                            }
                            else
                            {
                                up = mid - 1;
                            }
                            if (valid == false)
                            {
                                Console.WriteLine("Number not found");
                            }
                        }
                    }
                    else
                    {
                        bool check = false;
                        for (int i = 0; i < road.Length; i++)
                        {
                            if (road[i] == num)
                            {
                                Console.WriteLine(num + " is found on line " + i);
                                check = true;
                            }
                        }
                        if (check == false)
                        {
                            Console.WriteLine("Number not found");
                        }
                    }
                    break;
                case "4":
                    if (Roads.Sort4 == true)
                    {
                        int mid = 0;
                        int low = 0;
                        decimal temp;
                        int up = road.Length - 1;
                        bool valid = true;
                        while (valid == true && low <= up)
                        {
                            temp = low + ((up - low) / 2);
                            temp = Math.Floor(temp);
                            mid = decimal.ToInt32(temp);
                            if (road[mid] == num)
                            {
                                Console.WriteLine(num + " is found on line " + mid);
                                Binary(num, low, mid - 1, road);
                                Binary(num, mid + 1, up, road);
                                valid = false;
                            }
                            else if (road[mid] < num)
                            {
                                low = mid + 1;
                            }
                            else
                            {
                                up = mid - 1;
                            }
                            if (valid == false)
                            {
                                Console.WriteLine("Number not found");
                            }
                        }
                    }
                    else
                    {
                        bool check = false;
                        for (int i = 0; i < road.Length; i++)
                        {
                            if (road[i] == num)
                            {
                                Console.WriteLine(num + " is found on line " + i);
                                check = true;
                            }
                        }
                        if (check == false)
                        {
                            Console.WriteLine("Number not found");
                        }
                    }
                    break;
                case "5":
                    if (Roads.Sort5 == true)
                    {
                        int mid = 0;
                        int low = 0;
                        decimal temp;
                        int up = road.Length - 1;
                        bool valid = true;
                        while (valid == true && low <= up)
                        {
                            temp = low + ((up - low) / 2);
                            temp = Math.Floor(temp);
                            mid = decimal.ToInt32(temp);
                            if (road[mid] == num)
                            {
                                Console.WriteLine(num + " is found on line " + mid);
                                Binary(num, low, mid - 1, road);
                                Binary(num, mid + 1, up, road); valid = false;
                            }
                            else if (road[mid] < num)
                            {
                                low = mid + 1;
                            }
                            else
                            {
                                up = mid - 1;
                            }
                            if (valid == false)
                            {
                                Console.WriteLine("Number not found");
                            }
                        }
                    }
                    else
                    {
                        bool check = false;
                        for (int i = 0; i < road.Length; i++)
                        {
                            if (road[i] == num)
                            {
                                Console.WriteLine(num + " is found on line " + i);
                                check = true;
                            }
                        }
                        if (check == false)
                        {
                            Console.WriteLine("Number not found");
                        }
                    }
                    break;
                case "6":
                    if (Roads.Sort6 == true)
                    {
                        int mid = 0;
                        int low = 0;
                        decimal temp;
                        int up = road.Length - 1;
                        bool valid = true;
                        while (valid == true && low <= up)
                        {
                            temp = low + ((up - low) / 2);
                            temp = Math.Floor(temp);
                            mid = decimal.ToInt32(temp);
                            if (road[mid] == num)
                            {
                                Console.WriteLine(num + " is found on line " + mid);
                                Binary(num, low, mid - 1, road);
                                Binary(num, mid + 1, up, road);
                                valid = false;
                            }
                            else if (road[mid] < num)
                            {
                                low = mid + 1;
                            }
                            else
                            {
                                up = mid - 1;
                            }
                            if (valid == false)
                            {
                                Console.WriteLine("Number not found");
                            }
                        }
                    }
                    else
                    {
                        bool check = false;
                        for (int i = 0; i < road.Length; i++)
                        {
                            if (road[i] == num)
                            {
                                Console.WriteLine(num + " is found on line " + i);
                                check = true;
                            }
                        }
                        if(check == false)
                        {
                            Console.WriteLine("Number not found");
                        }
                    }
                    break;
            }
        }
    }
}
