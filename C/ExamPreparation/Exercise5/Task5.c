#include <stdio.h>
void sort(int arr[], int n) {

	for (int i = 1; i < n; i++)
	{
		int current = arr[i];
		int prev = i - 1;

		//int arr[] = { 11, 32, 10, 44, 1 };
		// 10 1 11 32 44
		int previousNumber = arr[prev];
		while (prev >= 0 && previousNumber > current) {
			arr[prev + 1] = arr[prev];
			prev = prev - 1;
		
			previousNumber = arr[prev];
		}


		arr[prev + 1] = current;
	}
}
int main() {
	int arr[] = { 11, 32, 10, 44, 1 };
	int size = (sizeof(arr) / sizeof(arr[0]));

	sort(arr, size);

	
	return 0;
}
