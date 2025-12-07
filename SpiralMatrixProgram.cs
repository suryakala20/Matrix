using System;
class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int n = int.Parse(Console.ReadLine());
        int[,] mat = new int[m, n];
        Console.WriteLine("Enter matrix elements");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int top = 0, bottom = m - 1, left = 0, right = n - 1;
        Console.WriteLine("Spiral Order:");
        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++)
                Console.Write(mat[top, j] + " ");
            top++;
            for (int i = top; i <= bottom; i++)
                Console.Write(mat[i, right] + " ");
            right--;
            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                    Console.Write(mat[bottom, j] + " ");
                bottom--;
            }
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    Console.Write(mat[i, left] + " ");
                left++;
            }
        }
    }
}
