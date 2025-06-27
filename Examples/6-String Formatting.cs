// String Formatting
// This code will show some of the many ways of formatting a string.

class Program
{
    static void Main()
    {
        string Text = "Hello! This is a separate variable.";

        // Add a dollar sign ($) before the quotation marks (") to use interpolation
        string Interpolation = $"Interpolation is used when you will use variables inside a string. We can use constants like {Math.PI}, expressions like {true && false}, or our own variables like {Text}";

        // Add an at sign (@) before the quotation marks (") to use verbatim
        string Verbatim = @"Verbatim\is\usually\used\for\file\paths as it ignores escaped characters. An example of an escaped character is \n which is a newline.";

        // Use 3 quotation marks instead of 1 to use raw string literals
        string Literal =
        """
        Raw string literals can span
        multiple lines, and have
            mutliple quotation marks (")
            inside them without problem.
        """;

        Console.WriteLine($"{Interpolation}\n\n{Verbatim}\n\n{Literal}\n\n");

        // Alternatively...
        Console.WriteLine("{0}, PI!", Math.PI);
        Console.WriteLine(Math.PI + ", PI!");
    }
}