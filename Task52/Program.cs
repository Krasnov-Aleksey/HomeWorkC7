//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

double AverageColumn (int[,] matrix, int j) //среднее арифметическое столбца
{
    double value=0;
    for (int i=0;i<matrix.GetLength(0); i++)
    {
        value=value+matrix[i,j];
    }
    value=value/matrix.GetLength(0);
    return value;
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
Console.WriteLine("Cреднее арифметическое");
for (int j=0; j<matrix.GetLength(1);j++)
{
    Console.Write($"{Math.Round(AverageColumn(matrix,j),2)} \t");
}


