// Basic Comments (Yes, there is depth even to comments.)
// This code will show basic types of comments. Comments do not interact with code and are usually used to explain the code they are next to.

class Program
{
    static void Main()
    {
        // Single-line comment
        /// Single-line comment, if you use this one, VSC for example will add '///' to the next line as well.
        /*
        Delimited comment
        */
        
        Console./*Delimited comments can be between codes (But they cannot split words!)*/WriteLine("Hello, world!");
    }
}