namespace Problems.CSharp.Problems._0003_Perfect_Number
{
    public class Problem_3
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

        public void PrintResult(int number)
        {
            if(IsPrimeNumber(number))
            {
                Console.WriteLine($"{number} Is prime number");
            }
            else
            {
                Console.WriteLine($"{number} Is not prime number");
            }
        }
    }
}
