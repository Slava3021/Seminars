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
        Console.WriteLine(" ]");
    }

}
int CreateMatrixSumDiagonal(int[,] array)
{
    int[,] matrix = array;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j) sum=sum+matrix[i,j];
        }

    }
    return sum;
}
int[,] array2D = CreateMatrixRndint(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int result= CreateMatrixSumDiagonal(array2D);
Console.WriteLine(result);





