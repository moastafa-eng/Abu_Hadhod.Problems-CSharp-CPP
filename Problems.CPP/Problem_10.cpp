#include <iostream>

using namespace std;

class Problem_10
{
private:

	int ReverseNumber(int number)
	{
		int container = 0;
		int remainder = 0;

		while (number > 0)
		{
			remainder = number % 10;
			number = number / 10;

			container = container * 10 + remainder;
		}

		return container;
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

	void PrintDigitsInOrder(int number)
	{
		int remainder = 0;

		int container = ReverseNumber(number);

		cout << "\nDigits in order are : " << endl;

		while (container > 0)
		{
			remainder = container % 10;
			container = container / 10;

			cout << remainder << endl;
		}
	}

};