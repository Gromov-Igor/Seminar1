// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

Console.WriteLine("Введите значение целое или не целое число"); // Вывод приглашения в терминале
double result = 1/Convert.ToDouble(Console.ReadLine);

double number = Convert.ToDouble(Console.ReadLine);
double result = 1/number;