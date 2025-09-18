using System;

class Program
{
    static void Main()
    {
        Matrix A = new Matrix(2, 3);
        Matrix B = new Matrix(3, 2);

        // Заповнення матриць
        int value = 1;
        for (int i = 0; i < A.Rows; i++)
        {
            for (int j = 0; j < A.Columns; j++)
            {
                A[i, j] = value++;
            }
        }

        value = 1;
        for (int i = 0; i < B.Rows; i++)
        {
            for (int j = 0; j < B.Columns; j++)
            {
                B[i, j] = value++;
            }
        }

        Console.WriteLine("Матриця A:");
        A.Print();

        Console.WriteLine("\nМатриця B:");
        B.Print();

        Matrix C = A * B;

        Console.WriteLine("\nA * B =");
        C.Print();
    }
}
