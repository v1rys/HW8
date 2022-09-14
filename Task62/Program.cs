// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

//[i+1,j]; [i,j+1]; [i-1, j]; [i,j-1]
Console.WriteLine("Введите количество строк вашего двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов вашего двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());

int composition = n * m;
int counter = 0;
int x = 0;
int i = 0;
int j = 0;
int count = 0;
int[,] arr = new int[n, m];
while (counter == composition)
{

    while (count < m - x && counter == composition)
    {
        arr[i, j] = counter++;
        i++;
        count++;
    }
    x++;
    count = 0;
    while (count < n - x && counter == composition)
    {
        arr[i, j] = counter++;
        j++;
        count++;

    }
    count = 0;
    while (count < m - x && counter == composition)
    {
        i--;
        arr[i, j] = counter++;
        count++;

    }
    x++;
    count = 0;
    while (count < n - x && counter == composition)
    {
        j--;
        arr[i, j] = counter++;
        count++;

    }

}

// я хоть в правильном направлении думаю??? подскажите) или ччерез for сделать?? 
// хотя через for я мало представляю как это сделать)

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
PrintMatrix(arr);