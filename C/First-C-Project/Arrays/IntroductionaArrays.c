#include<stdio.h>
int SumOfMyNums(int myNumbers[], int size);
int main() {
	int myNums[5];
	int size = sizeof(myNums) / sizeof(myNums[0]);


	for (int i = 0; i < size; i++) {
		int number;
		scanf_s("%d", &number);
		myNums[i] = number;
	}
	
	int sum = SumOfMyNums(myNums, size);

	printf("sum is - %d", sum);



	
	return 0;
}
int SumOfMyNums(int myNumbers[], int size) {
	int sumOfNums = 0;
	for (int i = 0; i < size; i++) {
		sumOfNums += myNumbers[i];
	}

	return sumOfNums;
}


/*int numbers[5];

	numbers[0] = 10;
	numbers[1] = 10;
	numbers[2] = 10;
	numbers[3] = 10;
	numbers[4] = 10;*/
	//
	//int grades[5] = { 5,5 };
	//
	//
	//for (int i = 0; i < 5; i++)
	//{
	//	printf("el value %d", numbers[i]);
	//}
/*int numbers[5];

	for (int i = 0; i < 5; i++)
	{
		int x;
		scanf_s("%d", &x);

		numbers[i] = x;
	}

	for (int i = 0; i < 5; i++)
	{
		printf("el value %d", numbers[i]);
	}*/