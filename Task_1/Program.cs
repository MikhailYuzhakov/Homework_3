/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

int[] array = new int[20];
int i = 0;
int number = 0;

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
number = Convert.ToInt32(Console.ReadLine());

while (number > 0) {
    array[i] = number % 10;
    number = number / 10;
    //Console.WriteLine(array[i]);
    i++;
}

if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine("Введенное число является палиндромом");
else Console.WriteLine("Введенное число не является палиндромом");