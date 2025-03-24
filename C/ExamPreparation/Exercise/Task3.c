#include<stdio.h>

int GetSecondMax(int arr[], int count) {
	int maxNumber = 0; // 10
	int secondMax = 0;
	for (int i = 0; i < count; i++) {

		if (maxNumber < arr[i])
		{
			maxNumber = arr[i];
		}
	}


	for (int i = 0; i < count; i++)
	{
		int curr = arr[i];
		if (arr[i] < maxNumber && secondMax < curr)
		{
			secondMax = arr[i];
		}

	}
	return secondMax;
}
int main() {
	int arr[] = { 12, 13, 14, 15, 16, 17, 2, 6, 7, 9 ,89, 100, 90 };
	int secondMax;
	secondMax = GetSecondMax(arr, sizeof(arr) / sizeof(arr[0]));
	printf("%d", secondMax);

али баба

	return 0;
}