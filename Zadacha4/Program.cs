﻿// Напишите программу вычисления функции:
// x = f (a) - возведение в куб

Console.Write("Введите число, которое будете возводить в куб > ");

int a = Convert.ToInt32(Console.ReadLine());
int x = a * a * a;

Console.WriteLine ($"Куб числа {a} равен {x}");