// Задача № 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int firstDigit = n / 10000;
int lastDigit = n % 10;
int secondDigit = (n / 1000) % 10;
int fourthDigit = (n % 100) / 10; 

if((n > 9999 && n <= 99999) || (n < -9999 && n >= -99999))
{
    if(firstDigit == lastDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine($"Число {n} -> является Палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {n} -> НЕ является Палиндромом");
    }
}
else
{
    Console.WriteLine("Введите 5-е число");
}