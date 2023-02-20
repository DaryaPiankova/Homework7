void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 101); // [1, 20]
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

void HorisontalTransponation(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0)/2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
            int temp=matrix[i,j];
            matrix[i,j]=matrix[matrix.GetLength(0)-i-1, j];
            matrix[matrix.GetLength(0)-i-1, j]=temp;
        }

    }
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
HorisontalTransponation(matrix);
Console.WriteLine("Конечный массив: ");
PrintMatrix(matrix);

