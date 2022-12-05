namespace _100CodingProblem.Models
{
    internal class CountOccurrencesOfaWordInString
    {
        private string str = "I am Shakik full name ibrahim khalil shakik";
        string[] words;
        private int count = 0;

        private string test = "Shakik";
        private char[] chars;
        private int count2 = 0;

        /***
         * Count words in a given string
         */
        public void Display()
        {
            words = str.Split(" ");

            foreach (string word in words)
            {
                if (String.Equals(word, "Shakik", StringComparison.CurrentCultureIgnoreCase))
                {
                    count++;
                }
                //Console.WriteLine(word);
            }

            if (count > 0)
            {
                Console.WriteLine(@"Shakik word occurs in string total = {0}", count);
            }
            else
            {
                Console.WriteLine("There is no occurrence");
            }
        }

        /***
         * Program to count occurrence of a given character in a string.
         */
        public void DisplayCharacters()
        {
            chars = test.ToCharArray();

            foreach (char c in chars)
            {
                if (c == 'k')
                {
                    count2++;
                }
            }

            Console.WriteLine("Character found: " + count2);
        }

        /***
         * How do you print the first non-repeated character from a string?
         */

        private string res = "ShakSha";
        public void DisplayNonRepeatingFirstCharacter()
        {
            chars = res.ToCharArray();

            for (var i = 0; i < chars.Length; i++)
            {
                if (res.IndexOf(chars[i], res.IndexOf(chars[i]) + 1) == -1)
                {
                    Console.WriteLine("First non-repeated character: " + chars[i]);
                }
            }
        }

        /***
         * How do you convert a given String into int like the atoi()?
         */

        private string result = "12343";
        public void AtoI()
        {
            chars = result.ToCharArray();
            int num = 0;

            for (var i = 0; i < chars.Length; i++)
            {
                num = num * 10 + chars[i] - '0';
            }
            Console.WriteLine("String to int: " + num);
        }
    }
}
