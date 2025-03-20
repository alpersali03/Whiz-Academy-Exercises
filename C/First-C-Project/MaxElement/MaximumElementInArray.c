#include <stdio.h>
int LargestEelement(int arr[], int n);
int main() {
    int arr[] = { 1, 2, 43, 57, 89 };
    int n = sizeof(arr) / sizeof(arr[0]);
    printf("%d", LargestEelement(arr, n));

    return 0;
}
int LargestEelement(int arr[], int n) {
    int max = arr[0];
    for (int i = 0; i < n; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
    }
    return max;
}