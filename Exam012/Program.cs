void Zadacha29()
{   
//Задача 29: Напишите программу, которая задаёт массив из 8 случайных 
//целых чисел и выводит отсортированный по модулю массив.
//-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
//6, 1, -33 -> [1, 6, -33]
int size = 8;
int[] array = new int [size];
array = FillArray(size);
PrintArray(array);
}

int[] FillArray(int size)
{
    int[] fillArr = new int[size];
    Random random = new Random();
    for (int i = 0; i < fillArr.Length; i++)
    {
        fillArr[i] = random.Next(-33, 20);
    }
    return fillArr;
}
void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    Array.Sort(array);
    foreach(int i in array) 
        {
            Console.Write(i + " ");
        }
}
Zadacha29();