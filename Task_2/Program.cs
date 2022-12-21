
void BaseMatrix(int[, ] matrix)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matrix[i, j] = new Random().Next(-10, 10); // [-10, 10]
        }
    }
}

Console.Clear();

int[,] matrix = new int[4, 3];
BaseMatrix(matrix);
Console.WriteLine("Введите позицию элемента");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
if (row < 4 && row > -1 && column < 3 && column > -1)
Console.WriteLine(matrix[row, column]);
else
Console.WriteLine("такой позиции в массиве нет");