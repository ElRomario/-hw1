using System;

/*C# 02 (18 сентября 2023)
Ветвления, циклы, случайность
Срок: к следующему занятию, четвергу 20 сентября

1. Игрок кидает три кубика снова и снова, пока в сумме не выпадет число 18. Программа считает, сколько попыток он сделает, пока не достигнет цели.

2. Пользователь вводит два целых числа, A и B, для примера 3 и 7. Программа должна напечатать трапецию из чисел:

3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7

Каждое число печатается на новой строке. Число 3 печатается 3 раза, число 4 печатается 4 раза и так далее. 
Мы начинаем с числа A и движемся вперёд, пока не достигнем числа B. Используйте вложенные циклы.*/

namespace hw1
{
    class Program
    {
        
    }
    class HW1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================TASK 1=================");
            int cube1 = 0, cube2 = 0, cube3 = 0;
            int tries = 1;
            Random rnd = new Random();
            while((cube1 + cube2 + cube3) != 18)
            {
                Console.WriteLine($"Try № {tries}");
                Console.WriteLine($"Cube 1: {cube1 = rnd.Next(0, 17)}");
                Console.WriteLine($"Cube 2: {cube2 = rnd.Next(0, 17)}");
                Console.WriteLine($"Cube 3: {cube3 = rnd.Next(0, 17)}");
                Console.WriteLine("==================================");

                tries++;
            }

            Console.WriteLine($" It took {tries} to win this game");

            Console.WriteLine("=================TASK 2=================");

            int lowBorder;
            int highBorder;

            Console.WriteLine("Enter low border");
            lowBorder = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter high border");
            highBorder = int.Parse(Console.ReadLine());

            for(int i = lowBorder; i <= highBorder; i++ )
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);

                }
                Console.WriteLine();
            }


        }
    }
}
