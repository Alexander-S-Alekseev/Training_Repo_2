// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int x;
Console.WriteLine("Ведите Число 1: ");
int y;
Console.WriteLine("Введите Число 2: ");
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
if (x == y)
    {
        System.Console.WriteLine("Числа равны");
    }
    else if (x > y)
    {
        System.Console.WriteLine("Число 1 больше Числа 2");
    }
    else
    {
        System.Console.WriteLine("Число 2 больше Числа 1");
    }
