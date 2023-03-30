//Заполнение диоганалями
void InputMatrix(int[,] matrix)
{
    int n = 0;
    matrix[0, 0] = 0;
    int a = matrix[0, 0];
    for (int i = 1; i < matrix.GetLength(1); i++)
    {
        n = i;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (n >= 0)
            {
                matrix[j, n] = a + 1;
                a = matrix[j, n];
                n--;
            }
        }
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        n = i;
        for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
        {
            //Console.WriteLine(j);
            if (n <matrix.GetLength(0))
            {
                //Console.Write(n);
                //Console.WriteLine(j);
                matrix[n, j] = a + 1;
                a = matrix[n, j];
                n++;
            }
        }
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

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);