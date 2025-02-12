using System;

class Program
{
    const int MAX_ELEMENTS = 100;

    static int Sum(int[] numbers)
    {
        int result = 0;
        foreach (int number in numbers)
        {
            result += number;
        }
        return result;
    }

    static int GetNumberOfElements()
    {
        int numberOfElements;
        Console.Write("Enter the number of elements (1-100): ");
        while (!int.TryParse(Console.ReadLine(), out numberOfElements) || numberOfElements < 1 || numberOfElements > MAX_ELEMENTS)
        {
            Console.WriteLine("Invalid input. Please provide a number ranging from 1 to 100.");
        }
        return numberOfElements;
    }

    static int[] GetElements(int numberOfElements)
    {
        int[] elements = new int[numberOfElements];
        Console.WriteLine($"Enter {numberOfElements} integers:");
        for (int i = 0; i < numberOfElements; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out elements[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        return elements;
    }

    static void Main()
    {
        int numberOfElements = GetNumberOfElements();
        int[] elements = GetElements(numberOfElements);

        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Sum");
        // Add more operations as needed
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                int totalSum = Sum(elements);
                Console.WriteLine("Sum of the numbers: " + totalSum);
                break;
            // Add more cases for other operations
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}