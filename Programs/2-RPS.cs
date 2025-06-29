// Required knowledges:
// 1 - Basic Data Types
// 2 - Basic Statement Types
// 4 - User Input
// 5 - Basic Operators
// 6 - String Formatting
// 7 - Random Class
// 8 - Methods

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

                switch (DetermineWinner(pcMove, input))
                {
                    case "draw":
                        draw++;
                        Console.WriteLine("It's a draw!");
                        break;
                    case "player":
                        win++;
                        Console.WriteLine("You win!");
                        break;
                    case "pc":
                        loss++;
                        Console.WriteLine("I win!");
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
    static string DetermineWinner(ConsoleKey pc, ConsoleKey player)
    {
        if (pc == player) { return "draw"; }
        else if ((pc == ConsoleKey.R && player == ConsoleKey.P) ||
                 (pc == ConsoleKey.P && player == ConsoleKey.S) ||
                 (pc == ConsoleKey.S && player == ConsoleKey.R))
                    { return "player"; }
        else { return "pc"; }
    }
}