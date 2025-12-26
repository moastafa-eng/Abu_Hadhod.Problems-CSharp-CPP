namespace Problems.CSharp.Problems._0009_Digit_frequency
{
    public class Problem_9
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

        private int CheckDigitFrequency(int number, int numberToCheck)
        {
            int freqCount = 0;
            int remainder = 0;

            while (number > 0)
            {
                remainder = number % 10;
                number = number / 10;

                if (numberToCheck == remainder)
                {
                    freqCount++;
                }
            }

            return freqCount;
        }

        public void PrintDigitFrequency(int number)
        {
            for (int i = 0; i < 10; i++)
            {
                int digitFrequency = 0;
                digitFrequency = CheckDigitFrequency(number, i);

                if(digitFrequency > 0)
                {
                    Console.WriteLine($"Digit {i} frequency is : {digitFrequency} time(s).");
                }
            }
        }
    }
}
