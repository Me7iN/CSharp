using System;

class Program
{
    static void Main()
    {
        string inputArrayOne = Console.ReadLine();
        string inputArrayTwo = Console.ReadLine();
        string[] inputOne = inputArrayOne.Split(' ');
        string[] inputTwo = inputArrayTwo.Split(' ');
        int[] arrayOne = new int[inputOne.Length];
        for (int i = 0; i < inputOne.Length; i++) 
        {
            arrayOne[i] = int.Parse(inputOne[i]);
        }
        int[] arrayTwo = new int[inputTwo.Length];
        for (int i = 0; i < inputTwo.Length; i++) 
        {
            arrayTwo[i] = int.Parse(inputTwo[i]);
        }
        int counterOfEquals = 0;
        if (arrayOne.Length != arrayTwo.Length)
        {
            Console.WriteLine("False");
        }
        else 
        {
            for (int i = 0; i < arrayOne.Length; i++) 
            {
                if (arrayOne[i] == arrayTwo[i]) 
                {
                    counterOfEquals++;
                }
            }
            if (counterOfEquals == arrayOne.Length)
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            }
        }
    }
}

