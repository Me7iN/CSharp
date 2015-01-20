using System;

class Program
{
    static void Main()
    {
        string inputArrayOne = Console.ReadLine();
        char[] delimeter = new char[] { ',', ' ' };
        string[] input = inputArrayOne.Split(delimeter, StringSplitOptions.RemoveEmptyEntries); ;
        int[] arrayOne = new int[input.Length];
        for (int i = 0; i < arrayOne.Length; i++)
        {
            arrayOne[i] = int.Parse(input[i]);
        }
        int counter = 0;
        int maxSequence = 0;
        int index = 0;
        for (int i = 0; i < arrayOne.Length; i++)
        {
            counter = 0;
            int j = i;
            while (arrayOne[i] == arrayOne[j])
            {
                counter++; 
                j++;
                if (j >= arrayOne.Length)
                {
                    break;
                }
            }
            if (counter > maxSequence)
            {
                maxSequence = counter;
                index = i;
            }
        }
        for (int i = index; i <= index + maxSequence - 1; i++)
        {
            if (i != index + maxSequence - 1)
            {
                Console.Write(arrayOne[i] + ", ");
            }
            else
            {
                Console.WriteLine(arrayOne[i]);
            }
        }

    }
}