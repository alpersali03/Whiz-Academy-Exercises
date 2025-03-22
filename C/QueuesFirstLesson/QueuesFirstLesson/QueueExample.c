#include <stdio.h>
#include <stdlib.h>

#define MAX 5 // Define the maximum size of the queue

// Declare the queue and variables to track the front and rear
int queue[MAX];

int frontIndex = -1; // Initially, the queue is empty, so front = -1
int rearUsedIndex = -1;  // Initially, the queue is empty, so rear = -1

// Function to check if the queue is full
int isFull() {
	return rearUsedIndex == MAX - 1;
}

// Function to check if the queue is empty
int isEmpty() {
	return frontIndex == -1 || frontIndex > rearUsedIndex;
}

// Enqueue operation to add an element to the queue
void enqueue(int value) {
	if (isFull()) {
		printf("Queue overflow! Cannot enqueue %d\n", value);
	}
	else {
		if (frontIndex == -1) // If the queue is initially empty
		{
			frontIndex = 0;
		}
		rearUsedIndex++;
		queue[rearUsedIndex] = value;
		printf("Enqueued %d\n", value);
	}
}

// Dequeue operation to remove and return the front element
int dequeue() {
	if (isEmpty()) {
		printf("Queue underflow! No elements to dequeue\n");
		return -1; // Return -1 to indicate the queue is empty
	}
	else {
		int dequeuedValue = queue[frontIndex];
		frontIndex++;
		if (frontIndex > rearUsedIndex) { // Reset the queue if all elements are dequeued
			frontIndex = -1;
			rearUsedIndex = -1;
		}
		return dequeuedValue;
	}
}

// Peek operation to view the front element without removing it
int peek() {
	if (isEmpty()) {
		printf("Queue is empty! No elements to peek\n");
		return -1;
	}
	else {
		return queue[frontIndex];
	}
}
int SumOfQueue() {
	int sum = 0;
	for (int i = 0; i < MAX; i++) {
		sum += queue[i];
		
	}
	return sum;
}

// Main function to demonstrate queue operations
int main() {
	// Queue operations
	enqueue(10);  // Add 10 to the queue
	enqueue(20);  // Add 20 to the queue
	enqueue(30);  // Add 30 to the queue
	enqueue(40);  // Add 40 to the queue
	enqueue(50);  // Add 50 to the queue
	enqueue(60);  // This enqueue will fail as the queue is full
	SumOfQueue();
	printf("Front element is %d\n", peek()); // Should print 10
	int sum = SumOfQueue();
	printf("%d", sum);
	printf("Dequeued %d from the queue\n", dequeue()); // Should remove and return 10
	printf("Dequeued %d from the queue\n", dequeue()); // Should remove and return 20
	printf("Dequeued %d from the queue\n", dequeue()); // Should remove and return 20
	printf("Dequeued %d from the queue\n", dequeue()); // Should remove and return 20
	printf("Dequeued %d from the queue\n", dequeue()); // Should remove and return 20
	printf("Dequeued %d from the queue\n", dequeue()); // Should remove and return 20

	printf("Front element is %d\n", peek()); // Should print 30

	return 0;
}
