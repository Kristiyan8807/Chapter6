//Напишете програма, която пресмята N!/K! за дадени N и K(1<K<N).
using System;

class Program
{
    static void Main()
    {

        int fact = 1;
        int n;
        int k;

        Console.Write("Enter N: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        k = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {

            fact = fact * i;

        }

        for (int i = 0; i < k; i++)
        {
            fact = fact * i;
        }

        Console.Write("The result is: {0}", n / k);





        //Console.Write("Enter N: (1<K<N) ");
        //int n = Int32.Parse(Console.ReadLine());
        //Console.Write("Enter K: (1<K<N) ");
        //int k = Int32.Parse(Console.ReadLine());

        //for (int i = n - 1; i > 0; i--)
        //{
        //    n *= i;
        //}

        //for (int i = k - 1; i > 0; i--)
        //{
        //    k *= i;
        //}

        //n /= k;
        //Console.WriteLine("Result is {0}", n);


    }
}

