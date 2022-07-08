void Zadacha29()
{   
//Задача 29: Напишите программу, которая задаёт массив из 8 случайных 
//целых чисел и выводит отсортированный по модулю массив.
//-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
//6, 1, -33 -> [1, 6, -33]
int size = 8;
int[] array = new int [size];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11);
}
Console.WriteLine();
Console.WriteLine("Вывод массива:");
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}
Console.WriteLine();
}
Zadacha29();