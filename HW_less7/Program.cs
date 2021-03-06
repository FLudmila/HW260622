//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
//округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
//void Zadacha47()
{
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
         
    double[,] DoubleArray = new  double[m,n];
    CreateDoubleArray(DoubleArray, 10);
    PrintDoubleArray(DoubleArray); 
}

double[,] CreateDoubleArray(double[,] array, int finishNumber)
{
    Random rand = new Random();
    int m =  array.GetLength(0);
    int n =  array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Math.Round(rand.NextDouble()*finishNumber, 1);
        }
    }
    return array;
}

double[,] PrintDoubleArray(double[,] array)
{
    int m =  array.GetLength(0);
    int n =  array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
    return array;
}
//Zadacha47();

//void Zadacha50()
{
    //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    //и возвращает значение этого элемента или же указание, что такого элемента нет.
    //Например, задан массив:
    //1 4 7 2
    //5 9 2 3
    //8 4 2 4
    //17 -> такого числа в массиве нет
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите элемент");
    int element = Convert.ToInt32(Console.ReadLine());
        
    int[,] Array = new int[m,n];
    CreateIntArray(Array);
    PrintIntArray(Array); 
    ElementInArray(Array, element);
}

int[,] CreateIntArray(int[,] arr)
{
    Random rand = new Random();
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    for (int i = 0; i <m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = rand.Next(1,10);
        }
    }
    return arr;
}

int[,] PrintIntArray(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

void ElementInArray(int[,] arr, int element)
{
    bool flag = false;
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j <n; j++)
        {
            if (arr[i,j] == element)
            {
                flag = true;
                break;
            }
        }       
    }

    if (flag == true)
    {
        Console.WriteLine($"Элемент - {element}, есть в массиве ");
    }
    else {Console.WriteLine("Такого элемента нет в массиве");}  
}
//Zadacha50();

void Zadacha52()
{
    //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    //Например, задан массив:
    //1 4 7 2
    //5 9 2 3
    //8 4 2 4
    //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] Array = new int[m,n];
    CreateIntArray(Array);
    PrintIntArray(Array); 
    AverageArray(Array);
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце");
    PrintArray(AverageArray(Array));
}

double[] AverageArray(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    double[] arr2 = new double[n];
    double sum = 0;
    int index = 0;

    for (int i = 0; i < n; i++)
    {
        sum = 0;
        for (int j = 0; j < m; j++)
        {
            sum += arr[j,i];
        }
        arr2[index] = Math.Round(sum/m, 2);
        index++; 
    }
    return arr2;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
}
Zadacha52();