// Негатив бинарного черно-белого изображения.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 2);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j]==0)
            {
                Console.Write("W");
            }
            else
            {
                Console.Write("B");
            }
        }
        Console.WriteLine();
    }
}

int ComparisonMatrix(int[,] matrix1, int[,] mairix2) //Сравнение 2 массивов
{
    int count=0;
    for(int i=0;i<matrix1.GetLength(0);i++)
    {
        for (int j=0;j<mairix2.GetLength(1);j++)
        {
            if(matrix1[i,j]!=mairix2[i,j])
                count++;
        }
    }
    return count;
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size[0], size[1]];
InputMatrix(matrix1);
Console.WriteLine("Изображение");
PrintMatrix(matrix1);
int[,] matrix2 = new int[size[0], size[1]];
InputMatrix(matrix2);
Console.WriteLine("Негатив");
PrintMatrix(matrix2);
Console.WriteLine($"Количество ошибок: {ComparisonMatrix(matrix1,matrix2)}");
