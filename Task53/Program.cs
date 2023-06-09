﻿// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[,] ChangeRowsAndColumns(int[,] matrix)
{
     int firstRow = 0;
     int lastRow = matrix.GetLength(0)-1;
     for (int i = 0; i < matrix.GetLength(1); i++)
     {
        int temp = matrix[firstRow,i];
        matrix[firstRow,i] = matrix[lastRow,i];
        matrix[lastRow,i] = temp;
     }
     return matrix;
}



int[,] matr = CreateMatrix(3, 4, 1, 10);
PrintMatrix(matr);
Console.WriteLine();
ChangeRowtoColumn(rndMatrix);
PrintMatrix(rndMatrix);