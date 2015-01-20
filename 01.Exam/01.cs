using System;

class Program
{
    static void Main()
    {
        int[] numbers =new int [20];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = 5 * numbers[i];
            Console.WriteLine(numbers[i]);
        }
    }
}
