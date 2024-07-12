using System;

// Partial class defined in one file with a parameterised constructor and a method
public partial class PartialClass 
{
    public PartialClass(String msg)
    {
        Console.WriteLine(msg);
    }
    public PartialClass()
    {
        Console.WriteLine("Partial class constructor defined in one file");
    }
}