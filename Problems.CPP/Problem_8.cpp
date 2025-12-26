# include <iostream>

using namespace std;

class  Problem_8
{
public:

	int ReadPositiveNumber(string message)
	{
		int number;

		do
		{
			cout << message;
			cin >> number;

		} while (number < 0);

			return number;
	}

	int checkDigitFrequncy(int number, int numberToCheck)
	{
		int FreqCount = 0;
		int remainder = 0;

		while (number > 0)
		{
			remainder = number % 10;
			number = number / 10;

			if (numberToCheck == remainder)
			{
				FreqCount++;
			}

		}

		return FreqCount;
	}
};