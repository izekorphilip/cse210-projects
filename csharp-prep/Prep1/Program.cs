using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your first name? ");
        string last = Console.ReadLine();
        
        string fullname = ($"Your name is {last}, {first} {last}.");
        Console.WriteLine(fullname);
    }    
}