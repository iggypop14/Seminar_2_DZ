// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
System.Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Convert.ToInt32(num/10);
//System.Console.WriteLine(num1); // Для контроля вывода
int num2 = Convert.ToInt32(num1%10);
System.Console.WriteLine(num2); // Вывод второй цифры