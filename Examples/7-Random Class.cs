// Random Class
// This code will show how to simply use the Random class.

class Program
{
    static void Main()
    {
        // First, we need to create a Random instance. We need to do this before we can use the methods of this class.
        Random R = new();

        Console.WriteLine("Random.Next()         = " + R.Next());          // Returns a random non-negative integer.
        Console.WriteLine("Random.Next(min, max) = " + R.Next(-100, 100)); // Returns a random integer higher than the first and lower than the second integer.
        Console.WriteLine("Random.Next(max)      = " + R.Next(100));       // Returns a random non-negative integer lower than the provided integer.
        Console.WriteLine("Random.NextSingle()   = " + R.NextSingle());    // Returns a random floating-point number between 0 and 1.
        Console.WriteLine();
        Console.WriteLine("If the same seed is used, the method will give the same values.");
        Console.WriteLine("Seed = 12345");
        R = new(12345);                                                    // Set a seed by providing an integer during instancing. If no seed is provided, it will be picked randomly.
        Console.WriteLine($"{R.Next()} - {R.NextSingle()} - {R.Next(100)}");
        R = new(12345);
        Console.WriteLine($"{R.Next()} - {R.NextSingle()} - {R.Next(100)}");
    }
}