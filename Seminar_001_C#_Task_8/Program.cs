Console.Write("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int even = 2;
int number = (n % even == 0);


while(number <= n)
{
    Console.Write(number + " ");
    number++;
}
