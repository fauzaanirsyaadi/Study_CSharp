using System;

class ExceptionHandlingExample
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null or empty.");
            }

            int number = int.Parse(input);

            // This will cause a divide by zero exception if number is 0
            int result = 100 / number;
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input was not a valid number. Please enter a valid integer.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Input cannot be null or empty.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}