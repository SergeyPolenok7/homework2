//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели");
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers <=5)
{Console.WriteLine("Рабочий день");}
else {Console.WriteLine("Выходной день");}
