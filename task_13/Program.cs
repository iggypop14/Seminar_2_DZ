// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/100;
//System.Console.WriteLine(num1); // Для контроля вывода
if(num1 < 1)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if(num1 >= 1 && num1 < 10)
{
    System.Console.WriteLine("Трёхзначное число");
    System.Console.WriteLine($"{num%100%10}");
}
else
{
    System.Console.WriteLine("Больше, чем трёхзначное>");
}