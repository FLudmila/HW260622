// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число!");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число!");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberOne > numberTwo){
    max = numberOne;   
}
else if (numberOne < numberTwo){
    max = numberTwo;   
}
Console.WriteLine($"Первое число {numberOne}, второе число {numberTwo} -> max={max} ");

