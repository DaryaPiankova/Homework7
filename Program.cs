void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
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

int GetPositionValue(int [] pos,int[,] matrix ){
    int value=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
            if(i==pos[0]-1 && j==pos[1]-1){
                value=matrix[i, j];
            }
        }
    }
    return value;
}



Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

Console.Write("Введите позицию элемента массива: ");
int[] pos = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

while(pos[0]>matrix.GetLength(0) ||pos[1]>matrix.GetLength(1) || pos[0]<0 || pos[1]<0 || pos[0] == 0 || pos[1]==0){
    Console.Write("Такой позиции нет!\nВведите позицию элемента массива: ");
pos = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
}

int result=GetPositionValue(pos, matrix);
Console.Write($"На позиции ({pos[0]}, {pos[1]}) находится элемент {result}");