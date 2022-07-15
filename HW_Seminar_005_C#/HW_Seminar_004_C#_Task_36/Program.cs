// Задача № 36:
// Задайте одномерный массив заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];
int sum = 0;
int count = 1;

FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) // проходимциклом по всему массиву
    {
        array[i] = new Random().Next(1, 77);
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
    if(numbers[i] % 2 == 1)
    {
        sum += numbers[i];
        count++;
    }
}

Console.WriteLine($"Сумма элементов на НЕчетных позициях равна: {sum}");