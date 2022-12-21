

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
// void raw_sum(int[, ] matrix)
// {
	
// for (int s = 0; s < matrix.GetLength(0); s++)	
// 	for (int k = 0; k < matrix.GetLength(0); k++)
// 	Console.WriteLine(sum = sum + matrix[k, l]);
// }


Console.Write("Введите размер матрицы: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);

int[,] matrix = new int[row, column];
InputMatrix(matrix);
int c = 0;
double n = 0;
double sum = 0;
for (int k = 0; k < matrix.GetLength(1); k++)
    {   
        sum = 0;
        for (c = 0; c < matrix.GetLength(0); c++)
        {   
            
            sum = sum + matrix[c, k];
            
        }
        n = sum / matrix.GetLength(0);
        Console.WriteLine($"{sum / matrix.GetLength(0)}");
    }