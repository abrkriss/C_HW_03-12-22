void Zadacha47()
{
    //Задача 47: Задайте двумерный массив размером m×n, 
    //заполненный случайными вещественными числами, округлёнными до одного знака.

    int rows = 3;
    int columns = 4;
    double[,] numbers = new double[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
}
void FillArray(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-20, 50)) / 10;
        }
    }
}

void PrintArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        //i = 0
        for (int j = 0; j < columns; j++)
        {
            //Console.Write($"A[{i}, {j}] = {numbers[i, j]}");
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Zadacha47();