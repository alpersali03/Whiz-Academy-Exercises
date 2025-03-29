#include<stdio.h>
#include <string.h>
#define MAX 20
char stack[MAX];
int top = -1;
int isFull() {
	return top == MAX - 1;
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
		stack[top] = c;
	}
}
char pop() {
	if (isFull()) {
		printf("Stack overflow! No characters to pop");
		return -1;
	}
	else {
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
	while (!isEmpty()) {
		printf("%c", pop());


	}
}

int main() {
	char word[6];
	gets_s(word, sizeof(word));

	for (int i = 0; i < strlen(word); i++)
	{
		push(word[i]);
	}

	PrintReverseString();


	return 0;
}