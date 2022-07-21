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
    Random random = new Random();
    int rows = random.Next(2, 5);
    int columns = random.Next(3, 6);
    int[,] array = new int[rows, columns];
    CreateIntArray(array);
    PrintArray(array);
    Console.WriteLine("Отсортированный массив");
    SortedArray(array);
    PrintArray(array);
}

int[,] CreateIntArray(int[,] arr)
{
    Random random = new Random();
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = random.Next(1,10);
        }
    }
    return arr;
}

int[,] PrintArray(int[,] arr)
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

int[,] SortedArray(int[,] arr)
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