using System;

public class Matrix
{
    private double[,] data;

    public int Rows { get; }
    public int Columns { get; }

    public Matrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        data = new double[rows, columns];
    }

    public double this[int i, int j]
    {
        get => data[i, j];
        set => data[i, j] = value;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Columns != b.Rows)
            throw new InvalidOperationException("Неможливо перемножити: кількість стовпців першої матриці має дорівнювати кількості рядків другої.");

        Matrix result = new Matrix(a.Rows, b.Columns);

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < b.Columns; j++)
            {
                double sum = 0;
                for (int k = 0; k < a.Columns; k++)
                {
                    sum += a[i, k] * b[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }

    public void Print()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.Write($"{data[i, j],6:F2} ");
            }
            Console.WriteLine();
        }
    }
}
