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
        public static int CountRepeatedCharacters(string str)
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

        /// <summary>
        /// Counts how many characters are repeated. For eg. "aabbcdef" is 2, because 'a' and 'b' is repeated
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int CountRepeatedCharactersLINQ(string str) => str.GroupBy(n => n).Where(g => g.Count() > 1).Count();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CharacterCounter.CountRepeatedCharacters("aaBBcdefg")); //2
            Console.WriteLine(CharacterCounter.CountRepeatedCharacters("Vicinity")); //1
            Console.WriteLine(CharacterCounter.CountRepeatedCharacters("aaBBccdd")); //4
            Console.WriteLine(CharacterCounter.CountRepeatedCharacters("abcdefg")); //0

            Console.WriteLine("------------");

            Console.WriteLine(CharacterCounter.CountRepeatedCharactersLINQ("aaBBcdefg")); //2
            Console.WriteLine(CharacterCounter.CountRepeatedCharactersLINQ("Vicinity")); //1
            Console.WriteLine(CharacterCounter.CountRepeatedCharactersLINQ("aaBBccdd")); //4
            Console.WriteLine(CharacterCounter.CountRepeatedCharactersLINQ("abcdefg")); //0

        }
    }
}