// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
string value = Console.ReadLine();
int dayofweek = Convert.ToInt32(value);
if (dayofweek < 8 && dayofweek > 0) {
    string[] week = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    Console.WriteLine($"{week[dayofweek - 1]}");
}

else {
    Console.WriteLine("Нет такого дня недели");
}