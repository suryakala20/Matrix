using System;

class TransaposeMatrix
{
    static void Main()
    {
        Console.Write("Enter size of square matrix n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] mat = new int[n, n];
        Console.WriteLine("Enter matrix elements");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = mat[i, j];
                mat[i, j] = mat[j, i];
                mat[j, i] = temp;
            }
        }
        Console.WriteLine("Transposed matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
