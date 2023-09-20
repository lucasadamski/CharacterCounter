using System.Reflection.Metadata.Ecma335;

namespace CharacterCounter
{

    public static class CharacterCounter
    {
        /// <summary>
        /// Counts how many characters are repeated. For eg. "aabbcdef" is 2, because 'a' and 'b' is repeated
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int CountCharacters(string str)
        {
            str = str.ToLower();
            string charactersChecked = "";
            int output = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (charactersChecked.Contains(str[i])) continue;
                for (int j = 0; j < str.Length; j++)
                {
                    if (i == j) continue;
                    if (str[i] == str[j])
                    {
                        output++;
                        charactersChecked += str[j];
                        break;
                    }
                }
            }

            return output;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CharacterCounter.CountCharacters("aaBBcdefg")); //2
            Console.WriteLine(CharacterCounter.CountCharacters("Vincinty")); //2
            Console.WriteLine(CharacterCounter.CountCharacters("aaBBccdd")); //4
            Console.WriteLine(CharacterCounter.CountCharacters("abcdefg")); //0

        }
    }
}