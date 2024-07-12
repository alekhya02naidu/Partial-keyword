using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Combines all the partial class files, 
        // merges it to one class
        // creates an object for it
        PartialClass partialClass = new PartialClass();
        PartialClass partialClass1 = new PartialClass("Parameterised constructor");

        string str = partialClass.Display();
        Console.WriteLine(str);
    }
}