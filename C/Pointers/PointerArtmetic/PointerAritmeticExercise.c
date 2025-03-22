#include <stdio.h>
int printArr(int* arr, int size) {
	int sum = 0;
	int* ptr = arr;
	for (int i = 0; i < size; i++)
	{
		sum += *ptr;
		ptr++;
	}
	return sum;
}

int main() {
	int arr[5] = { 10,20,30,40,60 };
	int size = sizeof(arr) / sizeof(arr[0]);
	int total = printArr(arr, size);

	printf("Sum of the array is: %d\n", total);
	return 0;
}