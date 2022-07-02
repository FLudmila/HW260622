//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
void Zadacha15()
{
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Да, выходной!");
}
else if (number > 7 || number < 1)
{
    Console.WriteLine("Ввод не верный");
}
else Console.WriteLine("Нет, будний день");
}
Zadacha15();