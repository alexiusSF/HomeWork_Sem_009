// Задача № 29
// Напишите программу, задает массив из 8 элементов и
// выводит их на экран.
// Вывод сделать отдельным методом.
// 1, 2, 5 ,7 19 -> [1, 2, 5 ,7 ,19]
// 6, 1, 33 -> [6, 1, 33]


int[] numbers = new int[8] {1, 2, 3, 4, 5, 6, 7, 8};

int[] array = new int[8];
PrintArray(numbers);

void PrintArray(int[] array)
{
    for (int i = 0; i < numbers.Length; i++)
    {
         Console.Write(numbers[i] + " ");
    }
}