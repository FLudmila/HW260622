//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//Zadacha21(3,2,6,1,8,-7);

Console.WriteLine("Введите координаты точки А: ");
int AX = Convert.ToInt32(Console.ReadLine());
int AY = Convert.ToInt32(Console.ReadLine());
int AZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int BX = Convert.ToInt32(Console.ReadLine());
int BY = Convert.ToInt32(Console.ReadLine());
int BZ = Convert.ToInt32(Console.ReadLine());

void Zadacha21(int AX, int AY, int AZ, int BX, int BY, int BZ)
{
Console.WriteLine(Math.Sqrt(Math.Pow((BY-AY),2)+Math.Pow((BX-AX),2)+ Math.Pow((BZ-AZ),2)));
}
Zadacha21(AX, AY, AZ, BX, BY, BZ);