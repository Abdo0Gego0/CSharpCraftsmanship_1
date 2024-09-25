using System;
    class program
{
   static void Main(String[] args)
    {
        int maxDistance = 0;
        //Definingt the number of array elements
        Console.WriteLine("Enter the number of elements N");
        int n = int.Parse(Console.ReadLine());

        //Decalring the array
        int[] arr = new int[n];

        //Enter the array
        Console.WriteLine("Enter the Array");
        for (int i = 0; i < n; i++)
            arr[i]= int.Parse(Console.ReadLine());

        // Printing the array
        Console.WriteLine("the Array you entered is :");
        foreach (int i in arr) 
            Console.Write(i + " ");
        Console.WriteLine(" ");
        // Loopig throw the array with 2 pointers
        for (int i = 0;i < arr.Length;i++)
            for (int j = 0;j < arr.Length;j++)
                if (arr[i] == arr[j])
                {
                    int distance = j - i -1; 
                    maxDistance = Math.Max(maxDistance, distance);
                }

        Console.WriteLine(" the max distance is ");
        Console.WriteLine(maxDistance + " ");
        

    }

}