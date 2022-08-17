int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ShowNewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

double[] ModifiedArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] /= array.Length;
    }
    return array;
}


Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
int[,] myArray = CreateArray(row, col);
ShowArray(myArray);

double[] sum = new double[col];

for (int i = 0; i < sum.Length; i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        sum[i] += myArray[j, i];
    }
}
Console.WriteLine("Массив сумм столбцов: ");
ShowNewArray(sum);
Console.WriteLine();
ModifiedArray(sum);
Console.WriteLine("Массив средних арифметичских: ");
ShowNewArray(sum);