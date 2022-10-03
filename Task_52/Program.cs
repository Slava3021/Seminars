
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int[,] CreateMatrixRndint(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("   ]");
    }

}
double ArithmeticMeanColumns(int[,] matrix)
{
    double sum = 0;
    double mean=0;
    int j=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = matrix[i, j] + sum;
            if(i==matrix.GetLength(0)-1 && j<matrix.GetLength(1))
            {
            mean = Math.Round(sum / matrix.GetLength(0), 1);
            Console.WriteLine($"среднее арифметическое столбцов = {mean}");
            j++;
            i=-1;
            sum=0;
            }
        }
    return mean;

}

int[,] array2D = CreateMatrixRndint(3, 4, 1, 9);
PrintMatrix(array2D);
double res = ArithmeticMeanColumns(array2D);