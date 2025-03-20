#include<stdio.h>
int CalulatePower(int base, int exponent);
int main() {
	int base1;
	int exponent1;
	scanf_s("%d", &base1);
	scanf_s("%d", &exponent1);
	int result = CalulatePower(base1, exponent1);
	printf("%d", result);

	return 0;
}
int CalulatePower(int base, int exponent) {
	int result = 1;
	for (int i = 1; i <= exponent; i++) {
		result *= base;
	}
	return result;
}