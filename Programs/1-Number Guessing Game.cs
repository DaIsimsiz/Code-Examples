// This is the first real program.
// Comments that explain the code will be scarce, so it is up to the reader to understand what most of the code does.
// Required knowledges:
// 1 - Basic Data Types
// 2 - Basic Statement Types
// 4 - User Input
// 5 - Basic Operators
// 7 - Random Class

class Program
{
    static void Main()
    {
        string input;
        int inputNumber;

        Random R = new();
        int randomNumber = R.Next(1000) + 1; //The range is 0-999 so we add 1 to make it 1-1000

        Console.WriteLine("What number am I thinking of?");
        while (true)
        {
            input = Console.ReadLine();

            if (int.TryParse(input, out inputNumber)) // The variable with 'out' keyword can be modified by the method!
            {
                if (inputNumber == randomNumber)
                {
                    Console.WriteLine("Yes, that's correct, you win!");
                    return;
                }

                else if (inputNumber > randomNumber) { Console.WriteLine("Lower..."); }

                else { Console.WriteLine("Higher..."); }
            }
            else { Console.WriteLine("That doesn't look like a number..."); } // Of course, the number might just be too high, but that's an edge case :)
        }
    }
}