//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 2 4 1
//9 5 3 2
//8 4 4 2
void Zadacha54()
{
    Random rand = new Random();
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите начальный диапазон чисел в массиве:");
    int startNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конечный диапазон чисел в массиве:");
    int finishNumber = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[rows, columns];
    Console.WriteLine("Задан массив:");
    FillMatrix(matrix, startNumber, finishNumber);
    PrintMatrix(matrix);
    Console.WriteLine("Отсортированный массив");
    SortedMatrix(matrix);
    PrintMatrix(matrix);
}

int[,] FillMatrix(int[,] arr, int startNumber, int FinishNumber)
{
    Random random = new Random();
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = random.Next(startNumber, FinishNumber);
        }
    }
    return arr;
}

int[,] PrintMatrix(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
    Console.WriteLine();
    }

    return arr;
}

int[,] SortedMatrix(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (arr[i, k] > arr[i, k + 1])
                {
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
                }
            }
        }
    }
    return arr;
}
Zadacha54();