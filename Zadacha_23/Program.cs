// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
int N;
Console.Write("Введите произвольное число: ");
N = Convert.ToInt32(Console.ReadLine());
Cube(N);
void Cube(int N)
{
    int Index = 1;
    int Cube = 0;
    {
    for(Index = 1; Index <= N; Index++);
    Cube = Math.Pow(Index, 3);
    Console.Write(Cube + " ");
    }
}





