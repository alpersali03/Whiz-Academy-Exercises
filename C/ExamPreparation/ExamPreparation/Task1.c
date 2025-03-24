#include<stdio.h>

#define N 4 // row
#define M 5 // col


int main() {

	int arr[N][M] = {
		{1,2,3,4,5},
		{6,7,8,9,10},
		{11,12,13,14,15},
		{16,17,18,19,20},
	};

	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < M; j++)
		{
			printf("%d ", arr[i][j]);
		}
		printf("\n");
	}

	for (int i = 0; i < N; i+=2)
	{
		for (int j = 0; j < M; j++)
		{
			arr[i][j] = arr[i + 1][M - 1 - j];
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