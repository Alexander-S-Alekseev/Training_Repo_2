// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandNum(array);
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
}

Console.WriteLine($"Разница между максимальным и минимальным значениями в массиве: {max - min}");

void FillArrayRandNum(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(0, 1000));
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.Write("]");
    Console.WriteLine();
}