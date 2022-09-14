// Задача 60. Сформируйте трёхмерный массив из неповторяющихся
//  двузначных чисел. Напишите программу, которая будет 
//  построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

double[,,] ourMatrix = GetMatrix(2, 2, 2, 10, 100);
PrintMatrix(ourMatrix);






double[,,] GetMatrix(int RowsCount, int columsCount, int inerColums, int LeftRenge, int rightRange)
{
    double[,,] matrix = new double[RowsCount, columsCount, inerColums];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                matrix[i, j, l] = rand.Next(LeftRenge, rightRange);
            }
        }

    }
    return matrix;
}

void PrintMatrix(double[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                Console.Write($"{matrix[i, j, l]}  [{i}{j}{l}]"+ " ");
            }
        }
        Console.WriteLine();

    }

}
