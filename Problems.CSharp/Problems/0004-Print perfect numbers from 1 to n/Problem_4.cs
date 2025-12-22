namespace Problems.CSharp.Problems._0004_Print_perfect_numbers_from_1_to_n
{
    public class Problem_4
    {
        public int ReadPositiveNumber(string Message)
        {
            int number;

            do
            {
                Console.Write(Message);
            } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);

            return number;
        }

        public bool IsPrimeNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return (number == sum) ? true : false;
        }

        public void PrintPerfectNumbers(int number)
        {
            Console.WriteLine("The perfect numbers are : ");

            for (int i = 1; i <= number; i++)
            {
                if(IsPrimeNumber(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
