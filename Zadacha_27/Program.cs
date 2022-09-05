// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите произвольное число: ");
string input = Console.ReadLine();
Console.WriteLine(Sum(input));
int Sum(string input);
{
    int result = 0;
    for (int i = 0; i < input.Length; i++);
    {
        result += result[i] - '0';
    }
    
}

