void Zadacha52()
{
    //Задача 52. Задайте двумерный массив из целых чисел. 
    //Найдите среднее арифметическое элементов в каждом столбце.

    int rows = 3;
    int columns = 3;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    for (int j = 0; j < columns; j++)
    {
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += numbers[i, j];
    }
    Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {(float)sum/rows}");

    }


}

void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
{
maxValue++;
Random rand = new Random();
int rows = numbers.GetLength(0);
int columns = numbers.GetLength(1);
for (int i = 0; i < rows; i++)
{
    for  (int j = 0; j < columns; j++)
    {
        numbers[i, j] = rand.Next(minValue, maxValue);
    }
}
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Zadacha52();