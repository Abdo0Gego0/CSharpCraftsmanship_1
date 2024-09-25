using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Sentence");
        string str = Console.ReadLine();

        // Split the string then Reverse the order of words and output then use join to concatnate into 1 output
        Console.WriteLine(string.Join(" ", str.Split(' ').Reverse()));
    }
}
