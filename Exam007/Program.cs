//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
        
Zadacha19(number);

void Zadacha19(int numb)
{
    if (numb/10000 >= 1 && numb/10000 <= 9 )
    {
        if (numb/10000 == numb%10 && numb/1000%10 == numb/10%10) {Console.WriteLine("Число - Палиндром");}
        else if (numb/10000 != numb%10 || numb/1000%10 != numb/10%10)
        {Console.WriteLine("Число не является палиндромом");}
    }
    else  {Console.WriteLine("Число не пятизначное");}
            
}
