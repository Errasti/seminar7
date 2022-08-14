int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 2;
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void PowerEven(int[,] array)
{
    for ( int i = 1; i < array.GetLength(0); i++)
    {
        for ( int j = 1; j < array.GetLength(1); j++)
        {
            if ( i % 2 == 0 && j % 2 == 0 )
            {
                array[i,j] *= array[i,j];
            }
        }
    }
}


Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
int[,] myArray = GetArray(row,col);
PowerEven(myArray);
ShowArray(myArray);
