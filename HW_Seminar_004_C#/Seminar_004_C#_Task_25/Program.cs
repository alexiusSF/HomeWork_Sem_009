// Задача № 25
// Напишите цикл, который принимает на вход два числа (А и В) и
// возводит число А в натуральную степень В.
// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень B: ");
int b = Convert.ToInt32(Console.ReadLine());

int naturalPower = a;
int count = 1;

while(count < b)
{
    naturalPower = naturalPower * a;
    count++;
}
Console.WriteLine(naturalPower);