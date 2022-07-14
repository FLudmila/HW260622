void Zadacha41()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    //0, 7, 8, -2, -2 -> 2
    //1, -7, 567, 89, 223-> 3
    int M = 5;

    int count = 0;
    for (int i = 0; i < M; i++) //i < 5; 0 1 2 3 4
    {
        Console.WriteLine();
        Console.Write($"Введите {i+1}-e число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    Console.WriteLine("Количество чисел больше нуля:"+ count);
}
Zadacha41();

//void Zadacha43()
{
    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    int k1 = 0;
    int b1 = 3;
    int k2 = 1;
    int b2 = 2;
    double x;
    double y;

    if (k1 != k2)
    {
        x = (b2 - b1)/(k1-k2);
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых ({x}, {y}");
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
    }
}
//Zadacha43();

