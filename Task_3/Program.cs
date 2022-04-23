/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

using static System.Math;

Console.Clear();
Console.WriteLine("Введите число N: ");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= count; i++) {
    Console.Write(Math.Pow(i, 3) + " ");
}
Console.WriteLine();