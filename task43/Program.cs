// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Даны две прямые 'y=k1*x+b1' и 'y=k2*x+b2'");
Console.WriteLine("Необходимо найти точку пересечения прямых");
Console.WriteLine("Введите значения k1");
int k1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите значения b1");
int b1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите значения k2");
int k2=int.Parse(Console.ReadLine());
Console.WriteLine("Введите значения b2");
int b2=int.Parse(Console.ReadLine());

int x = (b2-b1)/(k1-k2);
int y = k1*x +b1;

Console.WriteLine($"Координаты точек пересечения ({x}, {y})");
