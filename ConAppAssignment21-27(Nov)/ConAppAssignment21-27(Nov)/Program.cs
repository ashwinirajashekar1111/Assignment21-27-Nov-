using System;

// Step 1: Create a delegate
delegate int ArithmeticOperation(int a, int b);

class Program
{
    // Step 2: Implement static methods for arithmetic operations
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static int Divide(int a, int b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Cannot divide by zero. Returning 0.");
            return 0;
        }
    }

    static void Main()
    {
        // Step 3: Create instances of the delegate for each arithmetic method
        ArithmeticOperation addDelegate = Add;
        ArithmeticOperation subtractDelegate = Subtract;
        ArithmeticOperation multiplyDelegate = Multiply;
        ArithmeticOperation divideDelegate = Divide;

        // Step 4: Ask the user to input two integers
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine());

        // Step 5: Prompt the user to choose an arithmetic operation
        Console.WriteLine("Choose an arithmetic operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("Enter your choice (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        int result = 0;

        // Step 6: Call the corresponding method through the delegate and display the result
        switch (choice)
        {
            case 1:
                result = addDelegate(num1, num2);
                Console.WriteLine($"Result of Addition: {result}");
                break;
            case 2:
                result = subtractDelegate(num1, num2);
                Console.WriteLine($"Result of Subtraction: {result}");
                break;
            case 3:
                result = multiplyDelegate(num1, num2);
                Console.WriteLine($"Result of Multiplication: {result}");
                break;
            case 4:
                result = divideDelegate(num1, num2);
                Console.WriteLine($"Result of Division: {result}");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                break;
        }
    }
}

