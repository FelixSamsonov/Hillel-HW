using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload;

class Matrix
{
    public int[,] Values { get; set; }
    public int Rows { get; set; }
    public int Cols { get; set; }

    public Matrix(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        Values = new int[rows, cols];
    }
    public static Matrix operator +(Matrix A, Matrix B)
    {
        if (A.Cols != B.Cols || A.Rows != B.Rows)
            throw new ArgumentException("Matrix has to have same numbers rows and columns");
        else
        {
            Matrix C = new Matrix(A.Rows, B.Cols);
            for (int i = 0; i < A.Cols; i++)
            {
                for (int j = 0; j < B.Cols; j++)
                {
                    C.Values[i, j] = A.Values[i, j] + B.Values[i, j];
                }
            }
            return C;
        }
    }
    public static Matrix operator -(Matrix A, Matrix B)
    {
        if (A.Cols != B.Cols || A.Rows != B.Rows)
            throw new ArgumentException("Matrix has to have same numbers rows and columns");
        else
        {
            Matrix C = new Matrix(A.Rows, B.Cols);
            for (int i = 0; i < A.Cols; i++)
            {
                for (int j = 0; j < B.Cols; j++)
                {
                    C.Values[i, j] = A.Values[i, j] - B.Values[i, j];
                }
            }
            return C;
        }
    }
    public static Matrix operator *(Matrix A, Matrix B)
    {
        if (A.Cols != B.Cols || A.Rows != B.Rows)
            throw new ArgumentException("Matrix has to have same numbers rows and columns");
        else
        {
            Matrix C = new Matrix(A.Rows, B.Cols);
            for (int i = 0; i < A.Cols; i++)
            {
                for (int j = 0; j < B.Cols; j++)
                {
                    C.Values[i, j] = A.Values[i, j] * B.Values[i, j];
                }
            }
            return C;
        }
    }
    public static Matrix operator ++(Matrix A)
    {
            Matrix C = new Matrix(A.Rows, A.Cols);
            for (int i = 0; i < A.Cols; i++)
            {
                for (int j = 0; j < A.Rows; j++)
                {
                    C.Values[i, j] = A.Values[i, j] * 5;
                }
            }
            return C;
    }
    public static bool operator ==(Matrix A, Matrix B)
    {
        if (A.Rows != B.Rows || A.Cols != B.Cols)
            return false; 

        for (int i = 0; i < A.Rows; i++)
        {
            for (int j = 0; j < A.Cols; j++)
            {
                if (A.Values[i, j] != B.Values[i, j])
                    return false;
            }
        }
        return true; 
    }
    public static bool operator !=(Matrix A, Matrix B)
    {
        return !(A == B);
    }
         
    public void Show()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                Console.Write(Values[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
