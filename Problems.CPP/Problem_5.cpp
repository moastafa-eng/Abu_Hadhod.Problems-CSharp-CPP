#include <iostream>
#include <vector>

using namespace std;

class Problem_5 {

private:

	vector<int> ReversedNumber(int number)
	{
		vector<int> reversedNumber;
		int remainder = 0;

		while (number > 0)
		{
			remainder = number % 10; // extract the last digit from number
			number = number/10; // Remove the last digit after extracting

			reversedNumber.push_back(remainder);
		}

		return reversedNumber;
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

	void PrintResult(int number)
	{
		
		cout << "\nNumber after reversed : " << endl;

		for (int N : ReversedNumber(number))
		{
			cout << N << endl;
		}
	}
};