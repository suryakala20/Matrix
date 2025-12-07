using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int col = int.Parse(Console.ReadLine());
        if (row != col)
        {
            Console.WriteLine("Diagonal difference works only for a SQUARE matrix!");
            return;
        }
        int[,] matrix = new int[row, col];
        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int primarySum = 0;
        int secondarySum = 0;
        for (int i = 0; i < row; i++)
        {
            primarySum += matrix[i, i];
            secondarySum += matrix[i, row - 1 - i];
        }
        int result = Math.Abs(primarySum - secondarySum);
        Console.WriteLine("Primary Diagonal Sum = " + primarySum);
        Console.WriteLine("Secondary Diagonal Sum = " + secondarySum);
        Console.WriteLine("Absolute Difference = " + result);
    }
}
