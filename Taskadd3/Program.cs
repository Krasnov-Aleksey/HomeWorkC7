
void InputMatrix(int[,] matrix)
{
    // matrix[0,0]=0;
    // matrix[0,1]=1;
    // matrix[1,0]=matrix[0,1]+1;//2
    // matrix[0,2]=matrix[1,0]+1;//3
    // matrix[1,1]=matrix[0,2]+1;//4
    int n = 2;
    matrix[0, 0] = 0;
    int a = matrix[0, 0];
    for (int i = 1; i < matrix.GetLength(1); i++)
    {
        n=i;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (n >= 0)
            {
                matrix[j, n] = a + 1;
                a = matrix[j, n];
                n = n - 1;
            }

            // n=n-1;
            // matrix[i,n]=a+1;
            // a=matrix[i,n];
        }
    }
    //     for (int i = 0; i < matrix.GetLength(0); i++)
    //     {
    //         for (int j = 1; j < matrix.GetLength(1); j++)
    //             matrix[i, j] = new Random().Next(-10, 11);
    //     }
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
Console.WriteLine("Введите размерность массива: ");
//int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
//int[,] matrix = new int[size[0], size[1]];
int[,] matrix = new int[4, 4];
InputMatrix(matrix);
PrintMatrix(matrix);