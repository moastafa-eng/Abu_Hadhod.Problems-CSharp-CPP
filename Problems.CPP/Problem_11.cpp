#include <iostream>

using namespace std;

class Problem_11
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

	void ChekcPalindromeNumber(int number)
	{
		if (number == ReverseNumber(number))
		{
			cout << number << " is a palindrome number." << endl;
		}
		else
		{
			cout << number << " is not a palindrome number." << endl;
		}
	}

};