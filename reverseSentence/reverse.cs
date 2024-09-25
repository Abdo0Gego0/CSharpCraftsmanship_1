using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Sentence");
        string str = Console.ReadLine();

        // Reverse the order of words and output
        Console.WriteLine(string.Join(" ", str.Split(' ').Reverse()));
    }
}
