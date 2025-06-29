// Methods
// This code will explain the basics of methods.

class Program
{
    static void Main()
    {
        Console.WriteLine(AddNumbers(7, 17));
        Console.WriteLine(IsEven(43651));
        Console.WriteLine(Reverse("The quick brown fox jumps over the lazy dog."));

        foreach (string number in IntToStringArray([1, 2, 3, 4, 5]))
        {
            Console.WriteLine(number);
        }
    }

    // Methods are composed of 4 main parts
    static
    int            // Return type
    AddNumbers     // Method name
    (int a, int b) // Input variables
    {              /// Code
        Console.WriteLine("AddNumbers method was called!");
        return (a + b); // The "return" statement ends the code and returns the variable after it.
    }              /// Code 

    /////////////////////////////////////////
    // Below this are some other examples! //
    /////////////////////////////////////////

    static bool IsEven(int n) // Returns true if the number is even, otherwise returns false.
    {
        if (n % 2 == 0) // If the remainder is 0, that means the number is a multiple of 2 (even)
        { return true; }
        else
        { return false; }
    }

    static string Reverse(string text) // Reverses a string.
    {
        char[] reverse = text.ToCharArray();
        Array.Reverse(reverse);
        return new string(reverse);
    }

    static string[] IntToStringArray(int[] arr) // Converts an array of integers to an array of strings.
    {
        string[] returnArr = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            returnArr[i] = arr[i].ToString();
        }
        return returnArr;
    }
}

/// Output
// AddNumbers method was called!
// 24
// False
// .god yzal eht revo spmuj xof nworb kciuq ehT
// 1
// 2
// 3
// 4
// 5