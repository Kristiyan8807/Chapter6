//Напишете програма, която чете от конзолата числото N и отпечатва
//сумата на първите N члена от редицата на Фибоначи: 0, 1, 1, 2, 3, 5,
//8, 13, 21, 34, 55, 89, 144, 233, 377, ...
using System;

class Program
{
    static void Main()
    {

        int a = 0;
        int b = 1;
        int c;
        int number;
        Console.Write("Enter the number of elements: ");
        number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {

            c = a + b; // c stava 1
            a = b; // a stava 1
            b = c; // b stava 1
            Console.Write(c + "  ");
        }
    }
}
