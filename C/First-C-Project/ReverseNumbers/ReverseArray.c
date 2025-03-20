#include<stdio.h>
void ReverseArray(int arr[], int size);
int main() {
	int arr[5];
	int size = 5;

	printf("Enter 5 elements: ");
	for (int i = 0; i < size; i++) {
		scanf("%d", &arr[i]);
	}

	ReverseArray(arr, size);
	printf("Reversed array: ");
	for (int i = 0; i < size; i++) {
		printf("%d", &arr[i]);
	}


	return 0;
}

void ReverseArray(int arr[], int size)
{
	int start = 0;
	int end = size - 1;
	while (start < end) {
		int temp = arr[start];
		arr[start] = arr[end];
		arr[end] = temp;
		start++;
		end++;
	}
}
