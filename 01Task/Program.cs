//Напишете програма, която отпечатва на конзолата числата от 1 до N.
//Числото N трябва да се чете от стандартния вход.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Въведете число: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Числото е {0}",i);
        }
    }
}
