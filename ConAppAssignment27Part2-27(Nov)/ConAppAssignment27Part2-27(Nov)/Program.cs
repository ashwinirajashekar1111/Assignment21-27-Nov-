using System;
delegate T Operation<T>(T a, T b);

namespace ConApp_Assignment_21_p_2
{
    class Program
    {
        static T Add<T>(T a, T b) => (dynamic)a + b;
        static T Subtract<T>(T a, T b) => (dynamic)a - b;
        static T Multiply<T>(T a, T b) => (dynamic)a * b;
        static T Divide<T>(T a, T b)
        {
            if (b.Equals(default(T)))
            {
                Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
                return default;
            }
            else
            {
                return (dynamic)a / b;
            }
        }


        static void Main(string[] args)
        {
            Operation<int> addDelegate = Add;
            Operation<int> subtractDelegate = Subtract;
            Operation<int> multiplyDelegate = Multiply;
            Operation<int> divideDelegate = Divide;

            // Step 4: Ask the user to input two values of the same data type
            Console.Write("Enter the first value: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second value: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Step 5: Prompt the user to choose an operation
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = Convert.ToInt32(Console.ReadLine());

            // Step 6: Call the corresponding method through the generic delegate and display the results
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result of Addition: {addDelegate(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Result of Subtraction: {subtractDelegate(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Result of Multiplication: {multiplyDelegate(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Result of Division: {divideDelegate(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
   
