
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 1 || num > 7)
{
  System.Console.WriteLine("Вы ввели неверное число, попробуйте ещё раз ввести число от 1 до 7: ");  
}
else if(num >= 1 && num < 6)
{
    System.Console.WriteLine("Этот день является рабочим"); 
}
else
{
    System.Console.WriteLine("Этот день является выходным"); 
}
