using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using CodeWars.Programs;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateEncodeProgram.DuplicateEncode("din"));
        }

        

        public static bool IsSquare(int n)
        {
            if(n < 0) return false;
            
            if(n % Math.Sqrt(n) == 0) return true;
            return false;
        }

        public static int[] Divisors(int n)
        {
            List<int> divisors = new List<int>();
            for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) divisors.Add(i);
            if (divisors.Count == 0) return null;
            List<int> findLarge = new List<int>(Enumerable.Reverse(divisors.ToArray().Select(x => n / x).ToArray().Where(x => !divisors.Contains(x))));
            divisors.AddRange(findLarge);
            return divisors.ToArray();
        }

        /// <summary>
        /// finds the number that shows an odd number of times in the sequence
        /// </summary>
        /// <param name="seq">a sequence of numbers</param>
        /// <returns>integer</returns>
        public static int find_it(int[] seq) 
        {
            foreach(int i in seq)
            {
                var count = 0;
                foreach(int n in seq)
                {
                    if(i == n)
                    {
                        count++;
                    }
                }
                if(count % 2 != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
