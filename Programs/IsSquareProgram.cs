using System;

namespace CodeWars.Programs
{
    public static class IsSquareProgram
    {
        public static bool IsSquare(int n)
        {
            if(n < 0) return false;
            
            if(n % Math.Sqrt(n) == 0) return true;
            return false;
        }
    }
}