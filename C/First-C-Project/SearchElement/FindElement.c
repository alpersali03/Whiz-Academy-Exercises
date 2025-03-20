#include <stdio.h>
int SearchElement(int arr[], int n, int element);
int main() {
    int arr[] = { 91, 42, 33, 74, 25, 46, 17, 78, 99, 20 };
    int n = sizeof(arr) / sizeof(arr[0]);
    int element;
    scanf_s("%d", &element);
    int find = SearchElement(arr, n, element);

    if (find == -1) {
        printf("Not found number %d", element);
    }
    else {
        printf("Element is found at position: %d\n", find + 1);
    }

    return 0;
}
int SearchElement(int arr[], int n, int element) {
    for (int i = 0; i < n; i++) {
        if (arr[i] == element) {
            return i;
        }
    }
    return -1;
}