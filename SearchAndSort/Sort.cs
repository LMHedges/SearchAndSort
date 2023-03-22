using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSort
{
    class Sort
    {
        public static int[] Order(string input, int[] road, bool small)
        {
            int temp;
            switch (input)
            {
                case "1": //ascending order bubble sort
                    for (int i = 0; i <= road.Length - 2; i++)
                    {
                        for (int j = 0; j <= road.Length - 2; j++)
                        {
                            if (road[j] > road[j + 1])
                            {
                                temp = road[j + 1];
                                road[j + 1] = road[j];
                                road[j] = temp;
                            }
                        }
                    }
                    break;
                case "2": //descending order bubble sort
                    for (int i = 0; i <= road.Length - 2; i++)
                    {
                        for (int j = 0; j <= road.Length - 2; j++)
                        {
                            if (road[j] < road[j + 1])
                            {
                                temp = road[j + 1];
                                road[j + 1] = road[j];
                                road[j] = temp;
                            }
                        }
                    }
                    break;
            }
            int count = 0;
            if (small == true)
            {
                foreach (int num in road) //outputs every 10th value
                {
                    if (count % 10 == 0)
                    {
                        Console.WriteLine(num);
                    }
                    count++;
                }
            }
            else
            {
                foreach (int num in road) //outputs every 50th value
                {
                    if (count % 50 == 0)
                    {
                        Console.WriteLine(num);
                    }
                    count++;
                }
            }
            return road;
        }
    }
}
