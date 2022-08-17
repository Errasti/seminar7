int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random random = new Random();

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


Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
int[,] myArray = CreateArray(row, col);
ShowArray(myArray);

Console.WriteLine("Введите индекс строки:");
int userRow = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс столбца:");
int userCol = int.Parse(Console.ReadLine());

if ( userRow <= row - 1 && userCol <= col - 1)
{
    Console.WriteLine(myArray[userRow,userCol]);
}
else
{
    Console.WriteLine("Элемента с таким индексом - нет");
}
