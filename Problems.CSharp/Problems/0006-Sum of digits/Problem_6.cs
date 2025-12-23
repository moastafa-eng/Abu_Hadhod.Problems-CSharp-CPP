namespace Problems.CSharp.Problems._0006_Sum_of_digits
{
    public class Problem_6
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

        private List<int> TakeDigits(int number)
        {
            int remainder = 0;
            List<int> reversedNumbers = new List<int>();

            while (number > 0)
            {
                remainder = number % 10; // Take last digit from number
                number = number / 10; // Remove last digit from number

                reversedNumbers.Add(remainder);
            }

            return reversedNumbers;
        }

        public void SumDigits(int number)
        {
            int sum = 0;

            Console.WriteLine($"Sum digits of {number} is : ");

            foreach(int n in TakeDigits(number))
            {
                sum += n;
            }

            Console.Write(sum);
        }
    }
}
