//Напишете програма, която чете от конзолата поредица от цели числа и
//отпечатва най-малкото и най-голямото от тях.
using System;

class Program
{
    static void Main()
    {
        int min;
        int max;
        int number;
        Console.WriteLine("Моля въведете число: ");
        number = int.Parse(Console.ReadLine());
        min = number;
        max = number;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Моля въведете число: ");
            number = int.Parse(Console.ReadLine());
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}
