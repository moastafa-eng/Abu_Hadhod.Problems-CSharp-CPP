#include <iostream>

using namespace std;

class Problem_4 {
private:
	bool IsPerfectNumber(int number) {

		int sum = 0;

		for (int i = 1; i < number; i++) {

			if (number % i == 0)
			{
				sum += i;
			}
		}

		return (number == sum) ? true : false;
	}

public:

	int ReadPositiveNumber(string Message) {

		int number;

		do {
			cout << Message;
			cin >> number;

		} while (number <= 0);

		return number;
	}

	void PrintPerfectNumbers(int number)
	{
		cout << "\nPerfect numbers are : " << endl;

		for (int i = 1; i <= number; i++)
		{
			if (IsPerfectNumber(i))
			{
				cout << i << " ";
			}
		}
	}
};