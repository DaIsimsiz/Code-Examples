// Basic Data Types
// This file will show the most important data types. THis is not the full list, but they are the most important.

class Program
{
    static void Main()
    {
        // Range: [-2147483648 - 2147483647]
        int Integer    = 1234567890;

        // Range: [±1.5*10^−45 - ±3.4*10^38] Precision: 6-9 digits
        float Float    = 3.14159265f;

        // Range: [true, false]
        bool Boolean   = true;

        // Virtually infinite capacity
        string Text    = "The quick brown fox jumps over the lazy dog.";

        // Can store any single character
        char Character = 'ඞ';

        Console.WriteLine("       Integer value: " + Integer);
        Console.WriteLine("Floating point value: " + Float);
        Console.WriteLine("        String value: " + Text);
        Console.WriteLine("     Character value: " + Character);
        Console.WriteLine("       Boolean value: " + Boolean);
    }
}