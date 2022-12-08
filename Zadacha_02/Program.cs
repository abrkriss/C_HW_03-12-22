void Zadacha50()
{
    //Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
    //и возвращает значение этого элемента или же указание, что такого элемента нет.
    Console.WriteLine("Введите количество строк в массиве");
    int rows =  Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве");
    int columns =  Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    Console.WriteLine("Введите номер строки интересуемого элемента массива  ");
    int i = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите номер столбца интересуемого элемента массива  ");
    int j = Convert.ToInt32(Console.ReadLine());

    
        if ((i <=rows)&&(j < columns))
        {
            Console.WriteLine("Значение по заданному индексу  " + numbers[i, j]);
        }
        else
        {
            Console.WriteLine("Такого значение по этому индексу нет ");
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
        //i = 0
        for (int j = 0; j < columns; j++)
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
        //i = 0
        for (int j = 0; j < columns; j++)
        {
            //Console.Write($"A[{i}, {j}] = {numbers[i, j]}");
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Zadacha50();