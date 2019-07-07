using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars.Programs
{
    public static class Rot13Cypher
    {
        /// <summary>
        /// takes a string and replaces each character with a letter 13 places ahead in the alphabet
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string Rot13(string message)
        {
            string output = "";
            string messageLower = message.ToLower();

            for(int x = 0; x < message.Length; x++)
            {
                if(!Regex.IsMatch(message[x].ToString(), "[a-z]", RegexOptions.IgnoreCase))
                {
                    output += message[x];
                    continue;
                }

                byte[] charByte = Encoding.ASCII.GetBytes(messageLower[x].ToString());
                var value = charByte[0];
                
                for(int i = 0; i < 13; i++)
                {
                    value++;
                    if(value > 122)
                    {
                        value = 97;
                    }
                }
                byte[] valueArr = { value };
                char newChar = Encoding.ASCII.GetChars(valueArr).First();

                if(messageLower[x].ToString().ToUpper().Equals(message[x].ToString())) 
                    newChar = newChar.ToString().ToUpper().ToCharArray().First();

                output += newChar;
            }

            return output;
        }
    }
}