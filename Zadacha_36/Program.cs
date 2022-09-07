// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandNum(array);
PrintArray(array);
int sum = 0;

for (int i = 0; i < array.Length; i += 2)
    sum = sum + array[i];

Console.WriteLine($"Cумма элементов на нечётных позициях: {sum}");

void FillArrayRandNum(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100);
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.Write("]");
    Console.WriteLine();
}