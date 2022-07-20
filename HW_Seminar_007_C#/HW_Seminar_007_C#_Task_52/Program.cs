// Задача № 52
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// Среднее арифметическое столбца: 4,6; 5,6; 3,6; 3.

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarageValue = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarageValue = (avarageValue + numbers[i, j]);
    }
    avarageValue = avarageValue / m;
    Console.Write(avarageValue + "; ");
}
Console.WriteLine();

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
