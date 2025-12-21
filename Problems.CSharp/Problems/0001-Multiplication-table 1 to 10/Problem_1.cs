namespace Problems.CSharp.Problems._0001_Multiplication_table_1_to_10
{
    public class Problem_1
    {

        private void TableHeader()
        {
            Console.Write("\n\n\t\t\t\tMultiplication Table\n\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"\t{i}");
            }

            Console.Write("\n-----------------------------------------------------------------------------------\n");
        }
        private string ColumnSeperator(int number)
        {
            return (number is 10) ? "  |" : "   |";
        }
        public void PrintMultiplicationTable()
        {
            TableHeader();

            for (int i = 1; i <= 10; i++) 
            {
                Console.Write($" {i}{ColumnSeperator(i)}\t");
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }

                Console.WriteLine();
            }
        }
    }
}
