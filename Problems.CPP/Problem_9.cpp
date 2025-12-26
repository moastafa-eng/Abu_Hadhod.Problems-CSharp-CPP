#include <iostream>

using namespace std;

class Problem_9
{
private:
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

	void PrintAllDigitFrequecny(int number)
	{
		for (int i = 0; i < 10; i++)
		{
			int digitFrequency = 0;
			digitFrequency = checkDigitFrequncy(number, i);

			if (digitFrequency > 0)
			{
				cout << "Digit " << i << " frequency is : " << digitFrequency << endl;
			}
		}
	}
};