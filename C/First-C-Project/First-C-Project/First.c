#include <stdio.h>
int calculateSumOfDigits(int number);
int main() {
    int myNumber;
    scanf_s("%d", &myNumber);
    int calculatedSum = calculateSumOfDigits(myNumber);
    printf_s("%d", calculatedSum);
    
    return 0;
}
int calculateSumOfDigits(int number) {
    int sum = 0;
    while (number > 0) {
        int last = number % 10;
        sum += last;
        printf("last - %d\n", last);
        printf("last - %d\n", number);
        number /= 10;
    }

    return sum;
}