using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //dynamicAndStaticIntArrays();
        //stringarrays();
        //SayHi("Bob");
        //int number = 5;
        //int cubeResult = Cube(number);
        //Console.WriteLine($"The cube of {number} is: {cubeResult}");
        //Console.WriteLine(MaxOfThree(20, 15, 25)); // Output: 25
        //Console.WriteLine(MaxOfThree(7, 7, 7));    // Output: 7
        double num1, num2;
        char operation;

        // Getting inputs from the user
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        // Calculating and displaying the result
        string result = Calculator(num1, num2, operation);
        Console.WriteLine("Result: " + result);
    }
    //methods
    public static string Calculator(double num1, double num2, char operation)
    {
        double result;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                return result.ToString();
            case '-':
                result = num1 - num2;
                return result.ToString();
            case '*':
                result = num1 * num2;
                return result.ToString();
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    return result.ToString();
                }
                else
                {
                    return "Cannot divide by zero";
                }
            default:
                return "Invalid operation";
        }
    }
    public static int MaxOfThree(int a, int b, int c)
    {
        int max;

        if (a >= b && a >= c)
        {
            max = a;
        }
        else if (b >= a && b >= c)
        {
            max = b;
        }
        else
        {
            max = c;
        }

        return max;
    }

static int Cube(int num)
    {
        // Calculate the cube of the number
        int cube = num * num * num;
        return cube;
    }
    static void SayHi(string name)
    {
        Console.WriteLine("Hi, " + name + "!");
    }
    static void dynamicAndStaticIntArrays()
    {
        // Declare and initialize a static array
        int[] staticArray = new int[5];

        // Alternatively, you can initialize it with values
        int[] staticArrayWithValues = { 1, 2, 3, 4, 5 };

        // Create a dynamic array
        List<int> dynamicArray = new List<int>();

        // Ask the user for the size of the array
        Console.Write("Enter the size of the array: ");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size < 0)
        {
            Console.Write("Invalid input. Please enter a valid positive integer for the size of the array: ");
        }

        // Take input values from the user
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write($"Invalid input. Please enter a valid integer for value {i + 1}: ");
            }
            dynamicArray.Add(value);
        }

        // Output the values in the dynamic array
        Console.WriteLine("The values in the dynamic array are:");
        foreach (int value in dynamicArray)
        {
            Console.WriteLine(value);
        }
    }
    static void stringarrays() 
    {
        // Declare and initialize a static string array
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Output the elements of the array
        Console.WriteLine("The fruits array contains:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Access a specific element
        Console.WriteLine("The first fruit is: " + fruits[0]);

        // Modify an element
        fruits[2] = "Coconut";
        Console.WriteLine("The modified third fruit is: " + fruits[2]);

    }
}
