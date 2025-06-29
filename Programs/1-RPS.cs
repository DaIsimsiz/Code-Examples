// This is the first real program.
// Programs will not have any comments to explain the code whatsoever, so it is up to the reader to understand what each piece of code does.
// Required knowledges:
// 1 - Basic Data Types
// 2 - Basic Statement Types
// 4 - User Input
// 5 - Basic Operators
// 6 - String Formatting
// 7 - Random Class

class Program
{
    static void Main()
    {
        ConsoleKey input;
        ConsoleKey pcMove;

        int win = 0, loss = 0, draw = 0;
        ConsoleKey[] ValidMoves = [ConsoleKey.R, ConsoleKey.P, ConsoleKey.S];

        Random R = new();

        Console.WriteLine("Press a key to make a move! (R / P / S)");

        while (true)
        {
            input = Console.ReadKey().Key;
            
            if (ValidMoves.Contains(input))
            {
                pcMove = ValidMoves[R.Next(3)];
                Console.WriteLine($"Your move is: {input}\nI picked: {pcMove}");
                
                switch (pcMove)
                {
                    case ConsoleKey.R:
                        if      (input == ConsoleKey.R) { draw++; Console.WriteLine("It's a draw!"); }
                        else if (input == ConsoleKey.P) { win++;  Console.WriteLine("You win!");     }
                        else                            { loss++; Console.WriteLine("I win!");       }
                        break;
                    case ConsoleKey.P:
                        if      (input == ConsoleKey.R) { loss++; Console.WriteLine("I win!");       }
                        else if (input == ConsoleKey.P) { draw++; Console.WriteLine("It's a draw!"); }
                        else                            { win++;  Console.WriteLine("You win!");     }
                        break;
                    case ConsoleKey.S:
                        if      (input == ConsoleKey.R) { win++;  Console.WriteLine("You win!");     }
                        else if (input == ConsoleKey.P) { loss++; Console.WriteLine("I win!");       }
                        else                            { draw++; Console.WriteLine("It's a draw!"); }
                        break;
                }

                Console.WriteLine($"\nWins: {win} - Draws: {draw} - Losses: {loss}");
            }
            else
            {
                Console.WriteLine("That is not a valid move!");
            }
        }
    }
}