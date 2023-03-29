//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
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
Console.Write("Введите позиции элемента в двумерном массиве: ");
int[] pos = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int pos1=pos[0]-1;
int pos2=pos[1]-1;
if(pos1>=0 && pos1<matrix.GetLength(0) && pos2>=0 && pos2<matrix.GetLength(1))
{
    Console.WriteLine($"{matrix[pos1,pos2]}");
}
else 
{
    Console.WriteLine("Такого элемента нет");
}
