#include<stdio.h>
#define MAX 5 // Maximum size of the stack

// Declare a stack and a top variable to track the top of the stack
int stack[MAX];
int top = -1; // Initially, the stack is empty (top = -1

// Function to check if the stack is full
int isFull() {
	return top == MAX - 1;
}

// Function to check if the stack is empty
int isEmpty() {
	return top == -1;
}
// Push operation to add an element to the stack
void push(int value) {
	if (isFull()) {
		printf("Stack overflow! Cannot push %d\n", value);
	}
	else {
		// Move the top to the next position
		if (value % 2 == 0) {
			top++;
			stack[top] = value; // Add the value at the new top
		}
		printf("Pushed %d onto the stack\n", value);
	}
}


// 6
// Pop operation to remove and return the top element of the stack
int pop() {
	if (isEmpty()) {
		printf("Stack underflow! No elements to pop\n");
		return -1; // Return -1 to indicate the stack is empty
	}
	else {
		//int poppedValue = stack[top]; // Get the top element
		//stack[top] = 0;
		//top--;                        // Move the top down
		//return poppedValue;           // Return the popped value

		int currentNum = peek();

		if (currentNum > 10) {
			//int poppedValue = stack[top]; // Get the top element
					//stack[top] = 0;
					//top--;                        // Move the top down
					//return poppedValue; 
		}
	}
}

// Peek operation to view the top element without removing it
int peek() {
	if (isEmpty()) {
		printf("Stack is empty! No elements to peek\n");
		return -1;
	}
	else {
		return stack[top];
	}
}
void PrintAllNumbers() {
	for (int i = 0; i < MAX; i++)
	{
		stack[i];
		printf("%d -", stack[i]);
	}
	printf("\n");
}
// Main function to demonstrate stack operations
int main() {
	// Stack operations
	push(10);  // Push 10 onto the stack
	push(20);  // Push 20 onto the stack
	push(30);  // Push 30 onto the stack
	push(40);  // Push 40 onto the stack
	push(50);  // Push 50 onto the stack
	//push(60);  // This push will fail as the stack is fullc

	PrintAllNumbers();

	printf("top element is %d\n", peek()); // should return 50

	printf("popped %d from the stack\n", pop()); // should remove and return 50
	printf("popped %d from the stack\n", pop()); // should remove and return 40
	printf("top element is %d\n", peek()); // should return 30

	PrintAllNumbers();
	return 0;
}
