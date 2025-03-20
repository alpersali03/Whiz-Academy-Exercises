#include <stdio.h>
void BubbleSort(int arr[], int size);
int main() {
	int arr[] = { 65, 25, 12, 22, 11 };
	int size = sizeof(arr) / sizeof(arr[0]);

	BubbleSort(arr, size);

	for (int i = 0; i < size; i++) {
		printf("%d ", arr[i]);
	}

	return 0;
}

void BubbleSort(int arr[], int size) {
	for (int i = 0; i < size - 1; i++) {
		for (int j = 0; j < size - i - 1; j++)
		{
			int left = arr[j];
			int right = arr[j + 1];
			if (left > right)
			{
				int temp = left;

				arr[j] = arr[j + 1];
				arr[j + 1] = temp;
			}
		}
	}
}