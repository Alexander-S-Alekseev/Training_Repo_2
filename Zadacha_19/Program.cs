﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
string number;
Console.Write("Введите пятизначное число: ");
number = Console.ReadLine();
{
    if((number[0] == number[4]) && (number[1] == number[3]))
        {    
            Console.Write("Введенное число является полиндромом");
        }
    else
        {
            Console.Write("Введенное число не является полиндромом");
        }
}