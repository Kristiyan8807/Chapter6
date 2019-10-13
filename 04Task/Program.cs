//Напишете програма, която отпечатва всички възможни карти от
//стандартно тесте карти без джокери(имаме 52 карти: 4 бои по 13
//карти).
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 2; j < 15; j++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Спатия");
                        break;
                    case 2:
                        Console.WriteLine("Каро");
                        break;
                    case 3:
                        Console.WriteLine("Купа");
                        break;
                    case 4:
                        Console.WriteLine("Пика");
                        break;
                    default:
                        break;
                }
                switch (j)
                {
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                    case 4:
                        Console.WriteLine("4");
                        break;
                    case 5:
                        Console.WriteLine("5");
                        break;
                    case 6:
                        Console.WriteLine("6");
                        break;
                    case 7:
                        Console.WriteLine("7");
                        break;
                    case 8:
                        Console.WriteLine("8");
                        break;
                    case 9:
                        Console.WriteLine("9");
                        break;
                    case 10:
                        Console.WriteLine("10");
                        break;
                    case 11:
                        Console.WriteLine("J");
                        break;
                    case 12:
                        Console.WriteLine("Q");
                        break;
                    case 13:
                        Console.WriteLine("K");
                        break;
                    case 14:
                        Console.WriteLine("A");
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
