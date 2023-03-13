using System;
using static System.Console;

Clear();

Write("Введите количество строк первой матрицы: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов первой матрицы: ");
int columns=int.Parse(ReadLine());

Write("Введите количество строк второй матрицы: ");
int rows2=int.Parse(ReadLine());

Write("Введите количество столбцов второй матрицы: ");
int columns2=int.Parse(ReadLine());

int[,] array = Matrix1(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int[,] array1 = Matrix1(rows2, columns2, 0, 10);
PrintArray(array1);

int[,] Matrix1(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] Matrix2(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)

{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

int[,] MatrixRes = new int[rows,columns2];

Multiply(array, array1, MatrixRes);
Console.WriteLine($"\nПроизведение двух матриц:");
PrintArray(MatrixRes);

void Multiply(int[,] array, int[,] array1, int[,] MatrixRes)
{
  for (int i = 0; i < MatrixRes.GetLength(0); i++)
  {
    for (int j = 0; j < MatrixRes.GetLength(1); j++)
    {
      int mult = 0;
      for (int k = 0; k < MatrixRes.GetLength(1); k++)
      {
        mult += array[i,k] * array1[k,j];
      }
      MatrixRes[i,j] = mult;
    }
  }
}