//Транспонировать относительно горизонтали

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

void TransposeMatrix(int[,] matrix,int [,] tMatrix) //Транспонировать
{
    int l = 0;
    for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tMatrix[l, j] = matrix[i, j];
        }
        l++;
    }
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] tMatrix=new int[size[0],size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
Console.WriteLine("Новый массив");
TransposeMatrix(matrix, tMatrix);
PrintMatrix(tMatrix);