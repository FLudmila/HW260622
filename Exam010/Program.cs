void Zadacha25()
{
    //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
    //и возводит число A в натуральную степень B.
    //3, 5 -> 243 (3⁵)
    //2, 4 -> 16

    Random random = new Random();
    int number = random.Next(2,3);
    int exponent = random.Next(3,5);
    Console.WriteLine($"Число {number} в степени {exponent} равно {Power(number, exponent)}");
}

int Power( int number, int exponent)
{
    int result = 1;

    for (int i = 0; i < exponent; i++)
    {
        result *= number;
    }
    return result;
}
Zadacha25();