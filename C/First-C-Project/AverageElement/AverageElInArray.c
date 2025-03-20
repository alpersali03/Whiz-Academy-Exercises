#include <stdio.h>
int CalculateAverage(int arr[], int n);
int main() {
    int arr[] = { 1, 2, 3, 4, 5 };
    int n = sizeof(arr) / sizeof(arr[0]);
    printf("%d", CalculateAverage(arr, n));

    return 0;
}
int CalculateAverage(int arr[], int n) {
    int sum = 0;
    int finalSum = 0;
    for (int i = 0; i < n; i++) {
        sum += arr[i];
        finalSum = sum / n;
    }
    return finalSum;
}