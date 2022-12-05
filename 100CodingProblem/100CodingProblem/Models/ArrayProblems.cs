namespace _100CodingProblem.Models
{
    internal class ArrayProblems
    {
        /***
         * How do you remove duplicates from an array in place?
         */

        int[] numbers = new int[] { 3, 4, 5, 4 };
        private int[] temp = new int[5];
        private int m = 0;

        public void RemoveDuplicate()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    temp[m++] = numbers[i];
                }
            }

            for (var index = 0; index < temp.Length; index++)
            {
                int i = temp[index];
                Console.WriteLine(i);
            }
        }
    }
}
