// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8



int[,] GetMatrix(int RowsCount, int columsCount, int LeftRenge, int rightRange)
{
    int[,] matrix = new int[RowsCount, columsCount];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToInt32(new Random().Next(LeftRenge, rightRange));
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

void SortInAscendingOrderMassiv(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(1) - 1; x++)
            {
                if (matrix[i, x] > matrix[i, x + 1])
                {
                    int num = matrix[i, x];
                    matrix[i, x] = matrix[i, x + 1];
                    matrix[i, x + 1] = num;

                }
            }
        }
    }
}


int[,] ourMatrix = GetMatrix(4, 4, 1, 10);
PrintMatrix(ourMatrix);
SortInAscendingOrderMassiv(ourMatrix);
Console.WriteLine();
PrintMatrix(ourMatrix);
