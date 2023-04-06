// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// ------------Первая матрица----------
Console.Write("Введите количество строк 1-ой матрицы: ");
int m = int.Parse(Console.ReadLine()!);

//Так как кол-во столцов 1-ой матрицы должно быть = кол-ву строк 2-ой, то введем одну переменную для ввода
Console.Write("Введите количество столбцов 1-ой матрицы и строк 2-ой: ");
int n = int.Parse(Console.ReadLine()!);

int[,] OneArray = GetOneArray(m, n, 0, 10);
Console.WriteLine($"\n1-я Матрица: ");
PrintArray(OneArray);


// ------------Вторая матрица----------
Console.Write("Введите количество столбцов 2-ой матрицы: ");
int b = int.Parse(Console.ReadLine()!);

int[,] TwoArray = GetTwoArray(n, b, 0, 10);
Console.WriteLine($"\n2-я Матрица: ");
PrintArray(TwoArray);

// ------------------Перемноженные матрицы------------------
int[,] ResultArray = new int[m,b];
ResMatr(OneArray, TwoArray, ResultArray);
Console.WriteLine($"\nПеремноженные матрицы:");
PrintArray(ResultArray);

void ResMatr(int[,] OneArray, int[,] TwoArray, int[,] ResultArray)
{
  for (int i = 0; i < ResultArray.GetLength(0); i++)
  {
    for (int j = 0; j < ResultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int r = 0; r < OneArray.GetLength(1); r++)
      {
        sum += OneArray[i,r] * TwoArray[r,j];
      }
      ResultArray[i,j] = sum;
    }
  }
}

// ----------------Заполнение 1 - го массива
int[,] GetOneArray(int m, int n, int minValue, int maxValue)
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

// ----------------Заполнение 2 - го массива
int[,] GetTwoArray(int n, int b, int minValue, int maxValue)
{
    int[,] res = new int[n, b];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < b; j++)
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