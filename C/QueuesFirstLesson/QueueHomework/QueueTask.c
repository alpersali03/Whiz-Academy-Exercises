#include <stdio.h>
#include <stdlib.h>

#define MAX 100 // Define the maximum size of the queue

int queue[MAX];
int front = -1, rear = -1; // Queue initialization
int stack[MAX];
int top = -1; // Stack initialization

// Function to check if the queue is empty
int isQueueEmpty() {
    return front == -1 || front > rear;
}

// Function to enqueue an element into the queue
void enqueue(int value) {
    if (rear == MAX - 1) {
        printf("Queue overflow\n");
    }
    else {
        if (front == -1) front = 0; // If the queue is initially empty
        queue[++rear] = value;
    }
}

// Function to dequeue an element from the queue
int dequeue() {
    if (isQueueEmpty()) {
        printf("Queue underflow\n");
        return -1;
    }
    else {
        return queue[front++];
    }
}

// Function to check if the stack is empty
int isStackEmpty() {
    return top == -1;
}

// Function to push an element onto the stack
void pushStack(int value) {
    if (top == MAX - 1) {
        printf("Stack overflow\n");
    }
    else {
        stack[++top] = value;
    }
}

// Function to pop an element from the stack
int popStack() {
    if (isStackEmpty()) {
        printf("Stack underflow\n");
        return -1;
    }
    else {
        return stack[top--];
    }
}

// Function to reverse the queue using a stack
void reverseQueue() {
    // Dequeue all elements from the queue and push them onto the stack
    while (!isQueueEmpty()) {
        pushStack(dequeue());
    }

    // Pop all elements from the stack and enqueue them back into the queue
    while (!isStackEmpty()) {
        enqueue(popStack());
    }
}

// Function to display the elements of the queue
void displayQueue() {
    if (isQueueEmpty()) {
        printf("Queue is empty\n");
    }
    else {
        for (int i = front; i <= rear; i++) {
            printf("%d ", queue[i]);
        }
        printf("\n");
    }
}

int main() {
    // Enqueue elements into the queue
    enqueue(1);
    enqueue(2);
    enqueue(3);
    enqueue(4);
    enqueue(5);

    printf("Original Queue: ");
    displayQueue();

    // Reverse the queue
    reverseQueue();

    printf("Reversed Queue: ");
    displayQueue();

    return 0;
}
