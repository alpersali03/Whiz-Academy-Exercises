#include <stdio.h>
void printArr(int* arr, int size) {

	for (int i = 0; i < size; i++)
	{
		printf("val: %d\n", arr[i]);
	}
}

int main() {
	int arr[5] = { 10,20,30,40,60 };
	int size = sizeof(arr) / sizeof(arr[0]);
	int* ptr = arr;

	printf("Value of x: %d\n", *ptr);

	printArr(arr, size);
	return 0;
}
