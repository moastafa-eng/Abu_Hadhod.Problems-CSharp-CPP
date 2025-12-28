namespace Problems.CSharp.Problems._0010_Print_digits_in_order
{
    public class Problem_10
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

        public void PrintDigitsInOrder(int number)
        {
            int container = 0;
            int remainder = 0;

            container = ReverseNumber(number);

            Console.WriteLine("Digits in order are : ");

            while(container > 0)
            {
                remainder = container % 10;
                container = container / 10;

                Console.WriteLine(remainder);
            }
        }
    }
}
