// Create a list to hold random integers
List<int> ints = new List<int>();

// Create the Random instance outside the loop to ensure better randomness
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    int randNum = random.Next(1, 10);  // Generate a random number between 1 and 9
    ints.Add(randNum);  // Add the random number to the list
}

// Call both Min and Max methods to get the min and max values
Min(ints);
Max(ints);

// Method to find and print the minimum value
void Min(List<int> numbers)
{
    Console.WriteLine("Min value: " + numbers.Min());
}

// Method to find and print the maximum value
void Max(List<int> numbers)
{
    Console.WriteLine("Max value: " + numbers.Max());
}
