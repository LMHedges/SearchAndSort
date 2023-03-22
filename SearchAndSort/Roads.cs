using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchAndSort
{
    class Roads
    {
        public static int[] Road1 = new int[256];
        public static int[] Road2 = new int[256];
        public static int[] Road3 = new int[256];
        public static int[] Road4 = new int[2048];
        public static int[] Road5 = new int[2048];
        public static int[] Road6 = new int[2048];
        public static bool Sort1 = false;
        public static bool Sort2 = false;
        public static bool Sort3 = false;
        public static bool Sort4 = false;
        public static bool Sort5 = false;
        public static bool Sort6 = false;
        public static int[] small = new int[512];
        public static int[] large = new int[4096];
        public Roads()
        {
            int count = 0;
            foreach (string line in File.ReadLines(@"Road_1_256.txt"))
            {
                Road1[count] = int.Parse(line);
                count++;
            }
            count = 0;
            foreach (string line in File.ReadLines(@"Road_2_256.txt"))
            {
                Road2[count] = int.Parse(line);
                count++;
            }
            count = 0;
            foreach (string line in File.ReadLines(@"Road_3_256.txt"))
            {
                Road3[count] = int.Parse(line);
                count++;
            }
            count = 0;
            foreach (string line in File.ReadLines(@"Road_1_2048.txt"))
            {
                Road4[count] = int.Parse(line);
                count++;
            }
            count = 0;
            foreach (string line in File.ReadLines(@"Road_2_2048.txt"))
            {
                Road5[count] = int.Parse(line);
                count++;
            }
            count = 0;
            foreach (string line in File.ReadLines(@"Road_3_2048.txt"))
            {
                Road6[count] = int.Parse(line);
                count++;
            }
        }
    }
}
