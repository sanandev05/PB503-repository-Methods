namespace PB503_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------TASK 1----------------------------");
            Console.WriteLine(SumOfEvens(10));
            PrintSumOfEvens(10);

            Console.WriteLine("-------------------TASK 2----------------------------");
            Console.WriteLine(DeleteEmptyChars("Code Academy 2024"));
        }
        //This method only returns the sum of even number until defined number (not print)
        static int SumOfEvens(int number)
        {
            int sum = 0;

            for (int i = 2; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        //This method prints the sum of even number until defined number
        static void PrintSumOfEvens(int number)
        {
            int sum = 0;

            for (int i = 2; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        static string DeleteEmptyChars(string word)
        {
            string cleanedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    cleanedWord += word[i];
                }

            }
            return cleanedWord;
        }
    }
}
