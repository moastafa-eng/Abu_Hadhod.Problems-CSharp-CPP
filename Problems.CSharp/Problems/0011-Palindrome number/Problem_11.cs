namespace Problems.CSharp.Problems._0011_Palindrome_number
{
    public class Problem_11
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

        private int ReverseNumber(int number)
        {
            int remainder = 0;
            int container = 0;

            while (number > 0)
            {
                remainder = number % 10;
                number = number / 10;

                container = container * 10 + remainder;
            }

            return container;
        }

        public void CheckPalindromeNumber(int number)
        {

            int  container = ReverseNumber(number);

            if ( container == number)
            {
                Console.WriteLine($"{number} is a palindrome number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome number.");
            }
        }
    }
}
