using System;
class Program
{
    static void Main()
    {
        string inputArrayOne = Console.ReadLine();
        string inputArrayTwo = Console.ReadLine();
        char[] arrayOne = inputArrayOne.ToCharArray();
        char[] arrayTwo = inputArrayTwo.ToCharArray();
        int i = 0;
        int j = 0;
        bool equals = false;
        while (i < arrayOne.Length && j < arrayTwo.Length) 
        {
            if (arrayOne[i] > arrayTwo[j]) 
            {
                Console.WriteLine(inputArrayTwo);
                equals = false;
                break;
            }
            else if (arrayOne[i] < arrayTwo[j])
            {
                Console.WriteLine(inputArrayOne);
                equals = false;
                break;
            }
            else { equals = true; }
            i++;
            j++;
        }
        if (equals == true) 
        {
            if (arrayOne.Length < arrayTwo.Length) 
            {
                Console.WriteLine(inputArrayOne);
            }
            else if (arrayOne.Length > arrayTwo.Length)
            {
                Console.WriteLine(inputArrayTwo);
            }
            else 
            {
                Console.WriteLine("No Diference");
            }
        }
    }
}

