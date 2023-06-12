void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(-30, 31);
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);



Console.WriteLine("Введите позицию массива: ");
int a = size[0];
int b = size[1];


Console.WriteLine();
{}
    if (size[0] < 0 | size[0] > matrix.GetLength(0) - 1 | size[1] < 0 | size[1] > matrix.GetLength(1) - 1)
{
Console.WriteLine("Такой позиции нет ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[size[0], size[1]]);
}
Console.ReadLine();

