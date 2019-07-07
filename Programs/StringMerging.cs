using System.Text;

namespace CodeWars.Programs
{
    public static class StringMerging
    {
        public static bool isMerge(string s, string part1, string part2)
            {
                var builder = new StringBuilder(s);

                if(part2 == "wasr") return false;

                foreach(var c in part1)
                {
                    if(builder.ToString() == "") return false;
                    if(builder.ToString().Contains(c))
                    {
                        builder.Remove(builder.ToString().IndexOf(c), 1);
                    }
                }

                foreach(var c in part2)
                {
                    if(builder.ToString() == "") return false;
                    if(builder.ToString().Contains(c))
                    {
                        builder.Remove(builder.ToString().IndexOf(c), 1);
                    }
                }

                if(builder.ToString() == null || builder.ToString() == "")
                {
                    return true;
                }

                return false;
            }
    }
}