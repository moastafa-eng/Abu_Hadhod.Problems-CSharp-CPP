namespace Problems.CSharp.Problems._0005_Reversed_order
{
    public class Problem_5
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

        private List<int> ReversedNumbe(int number)
        {
            int remainder = 0;
            List<int> reversedNumbers = new List<int>();
            
            while(number > 0)
            {
                remainder = number % 10; // Take last digit from number
                number = number / 10; // Remove last digit from number

                reversedNumbers.Add(remainder);
            }

            return reversedNumbers;
        }

        public void PrintResult(int number)
        {
            Console.WriteLine("The number after reversed is : ");

            foreach(int n in ReversedNumbe(number))
            {
                Console.WriteLine(n);
            }
        }
    }
}
