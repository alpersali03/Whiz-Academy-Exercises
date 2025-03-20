#include <stdio.h>
int BubbleSort(int arr[], int n, int x);
int main() {
    int arr[] = { 1, 2, 3, 4, 3, 5, 6, 3, 7, 3, 8, 9, 3, 10 };
    int n = sizeof(arr) / sizeof(arr[0]);
    int x;
    scanf_s("%d", &x);
    int count = BubbleSort(arr, n, x);
    printf("%d", count);

    return 0;
}
int BubbleSort(int arr[], int n, int x) {
    int res = 0;
    for (int i = 0; i < n; i++) {
        if (x == arr[i]) {
            res++;
        }
    }
    return res;
}