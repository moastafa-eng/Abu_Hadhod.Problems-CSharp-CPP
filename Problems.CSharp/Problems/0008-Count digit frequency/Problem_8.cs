namespace Problems.CSharp.Problems._0008_Count_digit_frequency
{
    public class Problem_8
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

        public int CheckDigitFrequency(int number, int numberToCheck)
        {
            int freqCount = 0;
            int remainder = 0;

            while(number > 0)
            {
                remainder = number % 10;
                number = number / 10;

                if(numberToCheck == remainder)
                {
                    freqCount++;
                }
            }

            return freqCount;
        }
    }
}
