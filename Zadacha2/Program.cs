// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да
// if(a * a == b)

Console.WriteLine("введите первое число");
String number = Console.ReadLine();
int a = Convert.ToInt32(number);

Console.WriteLine("введите второе число");
String number1 = Console.ReadLine();
int b = Convert.ToInt32(number1);

if(b*b == a)
{
    System.Console.WriteLine($"число {a} является квадратом {b}");
}
else 
    System.Console.WriteLine($"число {a} не является квадратом {b}");