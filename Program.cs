void InputStartMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(i==0 && j>0 && j<3){
                matrix[i,j]='B';
            }else if(i==1){
                matrix[i,j]='B';
            }else if(i==2 && j>0 && j<3){
                matrix[i,j]='B';
            }else{
                matrix[i,j]='W';
            }
    }
}


void InputNegativeMatrix(char[,] matrix)
{
    char[] values={'B', 'W'};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] =values[new Random().Next(0,2)]; 
    }
}



void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int NegativeMatrix(char[,] matrix1, char[,]matrix2){
int counter=0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++){
                if(matrix1[i,j]=='B' && matrix2[i,j]=='B'){
                    counter++;
                    matrix2[i,j]='W';
                }else if(matrix1[i,j]=='W' && matrix2[i,j]=='W'){
                    counter++;
                    matrix2[i,j]='B';
                }
        }

    }
    return counter;
}
Console.Clear();

char[,] startMatrix = new char[3, 4];
char[,] negativeMatrix = new char[3, 4];
InputStartMatrix(startMatrix);

Console.WriteLine("Обычный рисунок: ");
PrintMatrix(startMatrix);

Console.WriteLine("Рисунок в негативе, полученный Мишиной программой: ");
InputNegativeMatrix(negativeMatrix);
PrintMatrix(negativeMatrix);

Console.Write("Количество ошибок Мишиной программы: ");
Console.WriteLine(NegativeMatrix(startMatrix, negativeMatrix));

Console.WriteLine("Корректный рисунок в негативе: ");
PrintMatrix(negativeMatrix);