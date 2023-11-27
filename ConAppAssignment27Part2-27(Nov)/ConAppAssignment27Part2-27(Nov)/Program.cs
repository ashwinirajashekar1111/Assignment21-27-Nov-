using System;

// Step 1: Create a generic delegate
delegate T Operation<T>(T x, T y);

class Program
{
    // Step 2: Implement static methods for operations
    static int Add(int x, int y) => x + y;
    static int Subtract(int x, int y) => x - y;
    static int Multiply(int x, int y) => x * y;
    static double Divide(int x, int y)
    {
        if (y != 0)
            return (double)x / y;
        else
        {
            Console.WriteLine("Cannot divide by zero. Returning 0.");
            return 0;
        }
    }

    // Additional methods for other data types (e.g., double)
    static double Add(double x, double y) => x + y;
    static double Subtract(double x, double y) => x - y;
    static double Multiply(double x, double y) => x * y;
    static double Divide(double x, double y)
    {
        if (y != 0)
            return x / y;
        else
        {
            Console.WriteLine("Cannot divide by zero. Returning 0.0.");
            return 0.0;
        }
    }

    static void Main()
    {
        // Step 3: Create instances of the generic delegate for each operation
        Operation<int> addDelegate = Add;
        Operation<int> subtractDelegate = Subtract;
        Operation<int> multiplyDelegate = Multiply;
        Operation<int> divideDelegate = Divide;

        Operation<double> addDoubleDelegate = Add;
        Operation<double> subtractDoubleDelegate = Subtract;
        Operation<double> multiplyDoubleDelegate = Multiply;
        Operation<double> divideDoubleDelegate = Divide;

        // Step 4: Ask the user to input two values of the same data type
        Console.Write("Enter the first value: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second value: ");
        string input2 = Console.ReadLine();

        // Convert the inputs to the appropriate type (int or double)
        int intValue1, intValue2;
        double doubleValue1, doubleValue2;

        bool isInt = int.TryParse(input1, out intValue1) && int.TryParse(input2, out intValue2);
        bool isDouble = double.TryParse(input1, out doubleValue1) && double.TryParse(input2, out doubleValue2);

        if (!(isInt || isDouble))
        {
            Console.WriteLine("Invalid input. Please enter values of the same data type (int or double).");
            return;
        }

        // Step 5: Prompt the user to choose an operation
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("Enter your choice (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        // Step 6: Call the corresponding method through the generic delegate and display the result
        switch (choice)
        {
            case 1:
                if (isInt)
                    Console.WriteLine($"Result of Addition: {addDelegate(intValue1, intValue2)}");
                else
                    Console.WriteLine($"Result of Addition: {addDoubleDelegate(doubleValue1, doubleValue2)}");
                break;
            case 2:
                if (isInt)
                    Console.WriteLine($"Result of Subtraction: {subtractDelegate(intValue1, intValue2)}");
                else
                    Console.WriteLine($"Result of Subtraction: {subtractDoubleDelegate(doubleValue1, doubleValue2)}");
                break;
            case 3:
                if (isInt)
                    Console.WriteLine($"Result of Multiplication: {multiplyDelegate(intValue1, intValue2)}");
                else
                    Console.WriteLine($"Result of Multiplication: {multiplyDoubleDelegate(doubleValue1, doubleValue2)}");
                break;
            case 4:
                if (isInt)
                    Console.WriteLine($"Result of Division: {divideDelegate(intValue1, intValue2)}");
                else
                    Console.WriteLine($"Result of Division: {divideDoubleDelegate(doubleValue1, doubleValue2)}");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                break;
        }
    }
}

