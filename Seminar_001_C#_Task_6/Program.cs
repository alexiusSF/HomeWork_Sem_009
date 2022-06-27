Console.WriteLine("Число делится на два без остатка ? ");

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int even = 2;

if (a % even == 0)
{
    Console.Write("ДА - ваше число делится на два без остатка");   
}
else
{
   Console.Write("НЕТ - ваше число делится на два без остатка");        
}
