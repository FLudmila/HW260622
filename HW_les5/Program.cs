void Zadacha34()
{   
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int size = 4;
int[] array = new int [size];
FillArray(array, 100, 999);
PrintArray(array);
PrintCount(array);
}

void FillArray(int[] array, int FirstNumber = 0, int LastNumber = 1)
{
    LastNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(FirstNumber, LastNumber);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

void PrintCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    Console.WriteLine("В массиве четных чисел " + count);
}

Zadacha34();

//void Zadacha36()
{   
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] array = new int [size];
array = FillArray(size);
PrintArray(array);
PrintCount(array);
}

int[] FillArray(int size)
{
    int[] fillArr = new int[size];
    Random random = new Random();
    for (int i = 0; i < fillArr.Length; i++)
    {
        fillArr[i] = random.Next(100, 999);
    }
    return fillArr;
}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76