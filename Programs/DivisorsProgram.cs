using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Programs
{
    public static class DivisorsProgram
    {
        /// <summary>
        /// finds the divisors of any number effieciently
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] Divisors(int n)
        {
            List<int> divisors = new List<int>();
            for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) divisors.Add(i);
            if (divisors.Count == 0) return null;
            List<int> findLarge = new List<int>(Enumerable.Reverse(divisors.ToArray().Select(x => n / x).ToArray().Where(x => !divisors.Contains(x))));
            divisors.AddRange(findLarge);
            return divisors.ToArray();
        }
    }
}