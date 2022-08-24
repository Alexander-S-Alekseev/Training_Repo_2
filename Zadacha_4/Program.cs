// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int MaxNumber = 0;
Console.WriteLine("Введите Число 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Число 2: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Число 3: ");
int z = Convert.ToInt32(Console.ReadLine());
if (x > y)
    {
    MaxNumber = x;
    }
    else
    MaxNumber = y;
    {
    if (z > MaxNumber)
    {
    System.Console.WriteLine("Числo 3 - максимальное");
    }
    else System.Console.WriteLine("Число 2 - максимальное");
    }