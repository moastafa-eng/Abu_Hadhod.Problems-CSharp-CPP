#include <iostream>
using namespace std;

class Problem_1{

private:

#pragma region Helper Methods
	void PrintTableHeader()
	{
		cout << "\n\n\t\t\t Multiplication Table\n\n";

		for (int i = 1; i <= 10; i++)
		{
			cout << "\t" << i;
		}

		cout << "\n-------------------------------------------------------------------------------------\n";
	}

	string ColumnSeperator(int i)
	{
		if (i < 10)
			return "   |";
		else
			return "  |";
	}
#pragma endregion


public: 

	void PrintMultiplicationTable()
	{
		PrintTableHeader();

		for (int i = 1; i <= 10; i++)
		{
			cout << " " << i << ColumnSeperator(i) << "\t";
			for (int j = 1; j <= 10; j++)
			{
				cout << i * j << "\t";
			}

			cout << endl;
		}
	}

};