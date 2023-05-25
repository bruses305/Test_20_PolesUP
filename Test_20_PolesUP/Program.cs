using System;

namespace Test_20_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Count = 0;

            bool easy = true;

            for(double i = Number-1;i>1;i--)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        easy = false;
                        break;
                    }
                }

                if (easy == true)
                {
                    Count++;
                }
                easy = true;
            }
            Console.WriteLine();
            Console.WriteLine("Вывод: " + Count);
        }
    }
}
