#include <iostream>

using namespace std;

class Problem_7
{

public:

	int ReadPositiveNumber(string Message) {

		int number;

		do {
			cout << Message;
			cin >> number;

		} while (number <= 0);

		return number;
	}

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
};