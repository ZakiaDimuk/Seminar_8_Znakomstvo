// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write($"\nВведите размер массива по X: ");
int X = Convert.ToInt32(Console.ReadLine()!);

Console.Write($"\nВведите размер массива по Y: ");
int Y = Convert.ToInt32(Console.ReadLine()!);

Console.Write($"\nВведите размер массива по Z: ");
int Z = Convert.ToInt32(Console.ReadLine()!);

int[,,] array = new int[X, Y, Z];
GetArray(array);
PrintArray(array);

// ----------------Заполнение массива
void GetArray (int[,,] array)
{
    int[] res = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  num;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        res[i] = new Random().Next(10, 100);
        num = res[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (res[i] == res[j])
                {
                    res[i] = new Random().Next(10, 100);
                    j = 0;
                    num = res[i];
                }
            num = res[i];
            }
        }
    }
    int count = 0; 
    for (int X = 0; X < array.GetLength(0); X++)
    {
        for (int Y = 0; Y < array.GetLength(1); Y++)
        {
            for (int Z = 0; Z < array.GetLength(2); Z++)
            {
                array[X, Y, Z] = res[count];
                count++;
            }
        }
    }
}

// -----------------Вывод массива-----------------
void PrintArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int a = 0; a < array.GetLength(2); a++)
      {
        Console.Write($"{array[i,j,a]}({i},{j},{a}) ");
      }
      Console.WriteLine();
    }
  }
}