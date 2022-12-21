﻿int upperBound = 100;
int lowerBound = -100;
void InputMatrix(double[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
			Random rand = new Random();
            matrix[i, j] = Math.Round(rand.NextDouble() * (upperBound - lowerBound) + lowerBound, 1); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
double[,] matrix = new double[row, column];
InputMatrix(matrix);