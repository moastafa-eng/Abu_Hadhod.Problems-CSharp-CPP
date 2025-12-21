namespace Problems.CSharp.Problems.Print_all__prime_numbers_from_1_to_n
{
    enum enPrimeNotPrime { prime = 1, notPrime = 2 };
    public class Problem_2
    {
        private enPrimeNotPrime CheckPrime(int number)
        {
            double m = Math.Round(Math.Sqrt(number));

            for (int count = 2; count <= m; count++)
            {
                if (number % count == 0)
                {
                    return enPrimeNotPrime.notPrime;
                }
            }

            return enPrimeNotPrime.prime;
        }

        public int ReadPositiveNumber(string Message)
        {
            int number;

            do
            {
                Console.Write(Message);
            } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);

            return number;
        }

        public void PrintPrimeNumbersFromOneToN(int number)
        {
            Console.WriteLine($"Prime numbers from one to {number} are: ");

            for(int i = 1; i <= number; i++)
            {
                if(CheckPrime(i) is enPrimeNotPrime.prime)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}



