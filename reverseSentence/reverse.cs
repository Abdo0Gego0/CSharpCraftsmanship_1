using System;
class program
{
    static void Main(String[] args)
    {
        Console.WriteLine(" Enter your Sentence");
        string str = Console.ReadLine();
        Console.WriteLine(string.Join(" ",str.Split(' ')[..^1].Reverse()));
    }
}