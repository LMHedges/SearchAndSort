using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSort
{
    class Merge
    {
        public static void Small() ////merge's road1 and road3
        {
            int i = 0;
            int j = 0;
            int count = 0;
            while (i < 256 && j < 256)
            {
                if (Roads.Road1[i] <= Roads.Road3[j])
                {
                    Roads.small[count] = Roads.Road1[i];
                    i++;
                }
                else
                {
                    Roads.small[count] = Roads.Road3[j];
                    j++;
                }
                count++;
            }
            while (i < 256)
            {
                Roads.small[count] = Roads.Road1[i];
                count++;
                i++;
            }
            while (j < 256)
            {
                Roads.small[count] = Roads.Road3[j];
                count++;
                j++;
            }
            count = 0;
            foreach (int num in Roads.small) //outputs every 10th value
            {
                if (count % 10 == 0)
                {
                    Console.WriteLine(num);
                }
                count++;
            }
        }
        public static void Large() //merge's road4 and road6
        {
            int i = 0;
            int j = 0;
            int count = 0;
            while (i < 2048 && j < 2048)
            {
                if (Roads.Road4[i] <= Roads.Road6[j])
                {
                    Roads.large[count] = Roads.Road4[i];
                    i++;
                }
                else
                {
                    Roads.large[count] = Roads.Road6[j];
                    j++;
                }
                count++;
            }
            while (i < 2048)
            {
                Roads.large[count] = Roads.Road4[i];
                count++;
                i++;
            }
            while (j < 2048)
            {
                Roads.large[count] = Roads.Road6[j];
                count++;
                j++;
            }
            count = 0;
            foreach (int num in Roads.large) //outputs every 50th value
            {
                if (count % 50 == 0)
                {
                    Console.WriteLine(num);
                }
                count++;
            }
        }
    }
}
