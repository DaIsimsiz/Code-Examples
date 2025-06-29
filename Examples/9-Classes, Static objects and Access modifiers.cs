// Classes, Static Objects and Access Modifiers
// This code will explain the basics of classes.
// Static objects and access modifiers are explained below. They are used to prevent accidental assignments / changes to important variables later.

class Program
{
    static void Main()
    {
        Contact friend = new("John Smith", 24, 123456789012, false);
        Console.WriteLine($"{friend.name}'s ({friend.age}{friend.Gender()}) number is {friend.number}.");
        Contact.Test();
    }
}
class Contact
{
    public string name;
    public int age;
    public long number;
    bool isFemale;
    // By default, classes are 'public' and anything inside them is 'private.'
    // 'public' objects can be accessed from outside, while 'private' objects can't.
    // In here, we keep 'isFemale' private so we can create a method to return 'M' or 'F' instead of 'true' or 'false.'

    public Contact(string a, int b, long c, bool d) // This is constructor. This method will help us create a "Contact" variable! This isn't the only way to do this, but it is one of the better methods.
    {
        name = a;
        age = b;
        number = c;
        isFemale = d;
    }

    public char Gender()
    {
        if (isFemale) { return 'F'; }
        else { return 'M'; }
    }

    public static void Test()
    {
        Console.WriteLine("This is a static method!");
    }
    // Anything not marked as 'static' is instanced, and is per-object. The way you reference static vs instanced methods/variables is:
    // Static =
        // Class.variable / Class.method()
    // Instanced =
        // Class myClass = new();
        // myClass.variable; / myClass.method(); 
}