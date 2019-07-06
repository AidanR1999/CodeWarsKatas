namespace CodeWars.Programs
{
    public class FindOddOccurencesProgram
    {
        /// <summary>
        /// finds the only odd occurences in a sequence of numbers
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
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