#include <iostream>

using namespace std;

enum enPrimeNotPrime { prime = 1, notPrime = 2 };

class Problem_2 {

private:

	enPrimeNotPrime CheckPrime(int number)
	{
		int m = round (sqrt(number));

		
		for (int count = 2; count <= m; count++)
		{
			if (number % count == 0)
			{
				return enPrimeNotPrime::notPrime;
			}
		}

		return enPrimeNotPrime::prime;
	}

public:

	int ReadPositiveNumber(string Message)
	{
		int number;

		do {
			cout << Message;
			cin >> number;
		} while (number <= 0);

		return number;
	}

	void PrintPrimeNumbersFromOneToN(int number)
	{
		cout << "\n";
		cout << "Prime numbers from 1  to " << number << " are: " << endl;

		for (int i = 1; i <= number; i++)
		{
			if (CheckPrime(i) == enPrimeNotPrime::prime) {
				cout << i << " ";
			}
		}
		cout << endl;
	}
};