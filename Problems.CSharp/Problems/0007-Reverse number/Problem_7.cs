namespace Problems.CSharp.Problems._0007_Reverse_number
{
    public class Problem_7
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

        public int ReverseNumber(int number)
        {
            int remainder = 0;
            int container = 0;

            while(number > 0)
            {
                remainder = number % 10;
                number = number / 10;

                container = container * 10 + remainder;
            }

            return container;
        }
    }
}
