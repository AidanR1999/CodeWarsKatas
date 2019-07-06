using System.Linq;
using System.Text;

namespace CodeWars.Programs
{
    public static class DuplicateEncodeProgram
    {
        /// <summary>
        /// replaces unique characters in a word with '('
        /// replaces repeating characters in a word with ')'
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            StringBuilder sb = new StringBuilder(word);

            for(int i = 0; i < word.Count(); i++)
            {
                var count = 1;
                
                if(i == word.Length - 1)
                {
                    if(!sb[i].Equals(')')) sb[i] = '(';
                    break;
                }

                for(int j = i + 1; j < word.Count(); j++)
                {
                    if(sb[j].Equals(sb[i]))
                    {
                        sb[j] = ')';
                        count++;
                    }
                }

                if(count == 1)
                {
                    sb[i] = '(';
                }

                if(count > 1)
                {
                    sb[i] = ')';
                }

            }

            return sb.ToString();
        }
    }
}