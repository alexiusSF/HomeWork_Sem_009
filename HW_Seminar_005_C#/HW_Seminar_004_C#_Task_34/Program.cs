// Задача № 34:
// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];
int sumPositive = 0;
int count = 1;

FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) // проходимциклом по всему массиву
    {
        array[i] = new Random().Next(99, 999);
    } 
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) // метод, который выводит массив
    {
        Console.Write(array[i] + " ");
    } 
    Console.WriteLine();
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 == 0)
    {
        sumPositive += count;
        count++;
    }
}

Console.WriteLine($"Количество четных чисел равна: {sumPositive}");