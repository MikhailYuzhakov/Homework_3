/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/
using static System.Math;

int ax, ay, az, bx, by, bz;
Console.Clear();
Console.WriteLine("Введите координаты точки А");
ax = Convert.ToInt32(Console.ReadLine());
ay = Convert.ToInt32(Console.ReadLine());
az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Б");
bx = Convert.ToInt32(Console.ReadLine());
by = Convert.ToInt32(Console.ReadLine());
bz = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Точка A(" + ax + ";" + ay + ";" + az + ")");
Console.WriteLine("Точка Б(" + bx + ";" + by + ";" + bz + ")");

double length = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
Console.WriteLine("Расстояние между точками = " + Math.Round(length, 2));