// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, заданы 2 массива:



int[,] ourMatrixOne = GetMatrix(4, 4, 1, 10);
PrintMatrix(ourMatrixOne);
Console.WriteLine();
int[,] ourMatrixTwo = GetMatrix(4, 4, 1, 10);
PrintMatrix(ourMatrixTwo);
Console.WriteLine();
SummaMassiveOneAndTwo(ourMatrixOne, ourMatrixTwo, 4, 4);






int[,] GetMatrix(int RowsCount, int columsCount, int LeftRenge, int rightRange)
{
    int[,] matrix = new int[RowsCount, columsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(LeftRenge, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();

    }

}

void SummaMassiveOneAndTwo(int[,] matrixOne, int[,] matrixTwo, int RowsCount, int columsCount)
{
    int[,] arr = new int[RowsCount, columsCount];

    for (int i = 0; i < columsCount; i++)
    {
        for (int j = 0; j < RowsCount; j++)
        {
            arr[i, j] = matrixOne[i, j] * matrixTwo[i, j];
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }



}



