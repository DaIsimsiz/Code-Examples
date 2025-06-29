// User Input
// This code will show 2 methods of getting input from the user as the code is running.

class Program
{
    static void Main()
    {
        // ReadLine will stop when ENTER is pressed.
        string InputString = Console.ReadLine();

        // ReadKey will stop as soon as any key is pressed.
        ConsoleKeyInfo InputKey = Console.ReadKey();

        Console.WriteLine("String: " + InputString);
        Console.WriteLine("Key   : " + InputKey.Key);

        if (InputKey.Key == ConsoleKey.Backspace)
        {
            Console.WriteLine("Backspace pressed!");
        }
    }
}

/// Input
// Hello, World!
// [Backspace]

/// Output
// Hello, World!
// String: Hello, World!
// Key   : Backspace
// Backspace pressed!