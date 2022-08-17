Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Factorial(int number)
{
    if (number == 1)
    {
        return number;
    }

    return number * Factorial(number - 1);
}


Console.WriteLine(Factorial(num));