void Zadacha27()
{
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Random random = new Random();
int number = random.Next (100,1000);

int sum = 0;

Console.Write("В числе " + number);
while(number > 0)
{
    sum += number % 10;
    number /=10;
}

Console.WriteLine("Сумма цифр равна: " + sum);

}
Zadacha27();