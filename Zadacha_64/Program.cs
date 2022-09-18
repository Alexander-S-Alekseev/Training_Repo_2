// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.WriteLine("Введите число M:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int max = Convert.ToInt32(Console.ReadLine());
PrintNumber(min, max);

void PrintNumber(int min, int max)
{
    if(min <= max)
    {
        Console.Write($"{min} ");
        PrintNumber(min+1,max);
    }
}