#include<stdio.h>

#define N 13 // row
#define M 13 // col


int main() {

	int arr[N][M];

	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
		{
			scanf_s("%d ", &arr[i][j]);
		}
		printf("\n");
	}

	for (int i = 0; i < N; i ++)
	{
		for (int j = i + 1; j < M; j++)
		{
			int temp = arr[i][j];

			arr[i][j] = abs(arr[j][i]);
			arr[j][i] = temp;

		}
	}
	printf("\n");

	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
		{
			printf("%d ", arr[i][j]);
		}
		printf("\n");
	}

	return 0;
}