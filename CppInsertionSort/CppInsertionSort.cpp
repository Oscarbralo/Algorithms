// TCTemplate.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <vector>
#include <iostream>

using namespace std;

class InsertionSort {
public:
	vector<int> insertionSort(vector <int> input) {
		for(int i = 1; i < input.size(); i++)
		{
			int key = input[i];
			int j = i - 1;
			while(j >= 0 && input[j] > key)
			{
				input[j + 1] = input[j];
                    j--;
			}
			input[j + 1] = key;
		}
		return input;
	}
};

int main()
{
	return 0;
}

