#include<stdio.h>
#include <string.h>
#define MAX 20
char stack[MAX];
int top = -1;
int isFull() {
	return top = MAX - 1;
}
int isEmpty() {
	return top == -1;
}
void push(char c) {
	if (isFull()) {
		printf("Stack overflow! Cannot push %c\n", c);
	}
	else {
		top++;
		return stack[top] = c;
	}
}
char pop() {
	if (isFull()) {
		printf("Stack overflow! No characters to pop");
		return -1;
	}
	else {
		top--;
		return stack[top--];
	}
}
char peek() {
	if (isEmpty()) {
		return '\0';
	}
	else {
		return stack[top];

	}

}
void PrintReverseString()
{
	for (int i = 0; i < MAX; i++) {
		printf("%c", peek());
		pop();
	}
}

int main() {
	for (int i = 0; i < 5; i++)
	{
		char symbol;
		scanf_s("%c", &symbol);
		push(symbol);
	}

	PrintReverseString();


	return 0;
}