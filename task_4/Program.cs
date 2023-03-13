﻿using System;
using static System.Console;

Clear();

Write("Введите количество массивов: ");
int mass_count=int.Parse(ReadLine());

Write("Введите количество столбцов: ");
int columns=int.Parse(ReadLine());

Write("Введите количество элементов: ");
int el_count=int.Parse(ReadLine());


int[,,] array = new int[mass_count, columns, el_count];

GetArray(array);
PrintArray(array);

void PrintArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Write( $"{array[i,j,k]} {(i,j,k)}; ");
      }
      WriteLine();
    }
    WriteLine();
  }
}


void GetArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

