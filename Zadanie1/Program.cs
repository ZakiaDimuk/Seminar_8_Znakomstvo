// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n, 0, 20);
PrintArray(array);

Console.WriteLine($"\nУпорядоченный массив: ");
ChangeArray(array);
PrintArray(array);

//---------------Элементы каждой строки по убыванию-----------
void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                if (array[i, a] < array[i, a + 1])
                {
                    int res = array[i, a + 1];
                    array[i, a + 1] = array[i, a];
                    array[i, a] = res;
                }
            }
        }
    }
}

// ----------------Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}