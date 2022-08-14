Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine());
int[,] array = new int[row, col];
Random random = new Random();

int[,] GetArray(int row, int col)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void ShowArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
}

ShowArray(GetArray(row,col));
