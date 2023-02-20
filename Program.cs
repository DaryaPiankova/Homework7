void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void ColumnAverage(double[,] matrix){
    double sum=0;
    for(int i=0; i<matrix.GetLength(1); i++){
        for(int j=0; j<matrix.GetLength(0); j++){
            sum=sum+matrix[j,i];
            if(j+1==matrix.GetLength(0)){
                int sumElements=j+1;
                Console.Write(sum/sumElements+" ");
                sum=0;
            }
        }
        
    }

}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
ColumnAverage(matrix);