// Basic Statement Types
// This file will show some of the most important statements. This is again, not a complete list, and there are many more for multiple other purposes, but these are the most important ones.

class Program
{
    static void Main()
    {
        int X = 10;
        int Y = 25;

        if (X > Y)       // The code below will execute if this condition is satisfied.
        {
            Console.WriteLine("X is higher than Y! This code must have been modified...");
        }
        else if (X == Y) // The code below will execute if the above condition(s) are not satisfied but this one is.
        {
            Console.WriteLine("X and Y have the same value, what a big surprise!");
        }
        else             // The code below will execute if none of the conditions above are satisfied.
        {
            Console.WriteLine("X is lower than Y, just as usual!");
        }
        Console.WriteLine();



        char KeyPressed = 'W';
        // Constant Pattern: Checks if the expression is equal to a constant.
        switch (KeyPressed) // (Expression)
        {
            case 'W': // (Constant)
                Console.WriteLine("Forward!!!");
                break;
            case 'S': // (Constant)
                Console.WriteLine("Retreat!!!");
                break;
            default: // This code will execute if nothing else works.
                Console.WriteLine("I don't know what this key does...");
                break;
        }

        int TestResult = 80;
        // Relational Pattern: Compares the expression to a constant.
        switch (TestResult) // (Expression)
        {
            case > 90:    // (Constant)
                Console.WriteLine("Ace!");
                break;
            case > 60:   // (Constant)
                Console.WriteLine("Pass!");
                break;
            default:     // This code will execute if nothing else works.
                Console.WriteLine("Fail...");
                break;
        }
        Console.WriteLine();
        // You can mix these up!



        for (int Index = 0; Index < 10; Index++)
        // Initializer - Condition - Iterator
        // Initializer is a local variable to keep track of which loop you are in.
        // As long as the condition is satisfied, the loop will keep going.
        // Iterator will be executed after the end of each loop. It is usually just "Initializer++" which increases the value of the initializer by 1. 
        {
            Console.WriteLine("Loop #" + Index);
        }
        Console.WriteLine();



        string[] Poem =
        [
            "Roses are red,",
            "Violets are blue.",
            "Unexpected '{' on line 32..."
        ];
        foreach (var Sentence in Poem)
        // Executes the code below for every element in the provided list.
        {
            Console.WriteLine(Sentence);
        }
        Console.WriteLine();



        int Countdown = 10;
        while (Countdown > 0)
        // The code below will run as long as the condition is satisfied.
        {
            Countdown--;
            Console.WriteLine(Countdown + "...");
        }
    }
}