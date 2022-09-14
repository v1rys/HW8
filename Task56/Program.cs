// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк вашего двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов вашего двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());

double[,] ourMatrix = GetMatrix(n, m, 200, 1000);
PrintMatrix(ourMatrix);
SummaNumbersVerticaliMassive(ourMatrix, n, m);





double[,] GetMatrix(int RowsCount, int columsCount, int LeftRenge, int rightRange)
{
    double[,] matrix = new double[RowsCount, columsCount];

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

void PrintMatrix(double[,] matrix)
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

void SummaNumbersVerticaliMassive(double[,] matrix, double RowsCount, double columsCount)
{
    //int [] arr = new int [RowsCount];
    double num = 0;
    double index = 0;


    for (int i = 0; i < RowsCount; i++)
    {
        double sum = 0;

        for (int j = 0; j < columsCount; j++)
        {
            sum = sum + matrix[i, j];

        }
        Console.WriteLine($"Сумма {i} строки = {sum}");

        if (sum > num)
        {
            num = sum;
            index = i;
        }
    
    }
    Console.WriteLine();
    Console.WriteLine($"строка с наибольшей суммой {index} и её сумма = {num}");

}