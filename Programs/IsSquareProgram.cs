using System;

namespace CodeWars.Programs
{
    public static class IsSquareProgram
    {
        /// <summary>
        /// checks if a given number is a squared number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsSquare(int n)
        {
            if(n < 0) return false;
            
            if(n % Math.Sqrt(n) == 0) return true;
            return false;
        }
    }
}