// Basic Operators
// This code will introduce some basic operators used for arithmetic, assignment, comparison and logic.

class Program
{
    static void Main()
    {
        int x = 5;
        bool result;

        // Arithmetic operators
        Console.WriteLine("Result of 'x = 5'      is: " + x);
        x++;
        Console.WriteLine("Result of 'x++'        is: " + x);
        x--;
        Console.WriteLine("Result of 'x--'        is: " + x);
        x = 3 * 5;
        Console.WriteLine("Result of 'x = 3 * 5'  is: " + x);
        x = 30 / 3;
        Console.WriteLine("Result of 'x = 30 / 3' is: " + x);
        x = 11 % 5; // Modulus returns the remainder after division
        Console.WriteLine("Result of 'x = 11 % 5' is: " + x);
        x = 7 + 8;
        Console.WriteLine("Result of 'x = 7 + 8'  is: " + x);
        x = 4 - 9;
        Console.WriteLine("Result of 'x = 4 - 9'  is: " + x);
        Console.WriteLine();

        // Assignment operators
        // "x += 20" is the same as "x = x + 20"
        x = 30;
        Console.WriteLine("Result of 'x = 30'  is: " + x);
        x += 7;
        Console.WriteLine("Result of 'x += 7'  is: " + x);
        x -= 11;
        Console.WriteLine("Result of 'x -= 11' is: " + x);
        x *= 4;
        Console.WriteLine("Result of 'x *= 4'  is: " + x);
        x /= 2;
        Console.WriteLine("Result of 'x /= 2'  is: " + x);
        x %= 5;
        Console.WriteLine("Result of 'x %= 5'  is: " + x);
        Console.WriteLine();

        // Comparison operators
        result = 1 == 1;   // True if the values are the same
        Console.WriteLine("Result of '1 == 1'   is: " + result);
        result = 20 < 50;  // True if the first value is lower than the second value
        Console.WriteLine("Result of '20 < 50'  is: " + result);
        result = 80 > 7;   // True if the first value is higher than the second value
        Console.WriteLine("Result of '80 > 7'   is: " + result);
        result = 40 <= 40; // True if the first value is lower than or equal to the second value
        Console.WriteLine("Result of '40 <= 40' is: " + result);
        result = 20 >= 21; // True if the first value is higher than or equal to the second value
        Console.WriteLine("Result of '20 >= 21' is: " + result);
        Console.WriteLine();

        // Logical operators
        Console.WriteLine("Result of '!true'           is: " + !true);
        Console.WriteLine("Result of '(true && false)' is: " + (true && false));
        Console.WriteLine("Result of '(true || flase)' is: " + (true || false));
    }
}