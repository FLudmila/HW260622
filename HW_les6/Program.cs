//void Zadacha41()
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
//Zadacha41();

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
        Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
    }

}
//Zadacha43();

//Семинарские задачи
//void Zadacha48()
{
    //Задача 48: Задайте двумерный массив размера m на n, 
    //каждый элемент в массиве находится по формуле: A = m+n. Выведите полученный массив на экран.
    int rows = 3;
    int columns = 4;

    int[,] array = new int[rows, columns];
    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
}

void FillArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
}

void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}
//Zadacha48();


void Zadacha49()
//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
int rows = 10;
int columnes = 10;
int[,] array = new int[rows, columnes];
Random rand = new Random();
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(0, 9);
            if ((i%2==0) && (j%2==0))
            {
              array[i, j] *= array[i,j]; 
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadacha49();

//Задача 51: Задайте двумерный массив. Найдите сумму 
//элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
void Zadacha51()
{
    int rows = 4;
    int columns = 5;

    int[,] array = new int[rows, columns];  
    
    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
    Console.WriteLine();
    SumArray(array, rows, columns);
}

void FillArray(int[,] array, int rows, int columns)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(1, 11);
        }
    }
}

void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
}
void SumArray(int[,] array, int rows, int columns)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if(i == j) 
            {
                sum += array[i, j];
                Console.Write(array[i, j] + "+");
            }
        }
    }
    Console.WriteLine($"=" + sum);
}

Zadacha51();
