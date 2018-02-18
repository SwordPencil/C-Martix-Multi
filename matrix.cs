using System;
using System.IO;

public class Matrix
{//Класс-шаблон: Матрица.
    private double[][] values; //Значения элементов матрицы. Тип значения может быть разный

    public Matrix()
    {
        values = null;
    }

    public Matrix(double[][] vals)
    {
        values = vals;
    }

    public Matrix(string name)
    {//Достает матрицу из файла
        string[] stringMartix = File.ReadAllLines(name);

        for (int i = 0; i < stringMartix.Length; i++)
            stringMartix[i] = stringMartix.Split(' ');
        values = new double[stringMartix.Length, firstString.Length];
    }

    override
    public string ToString()
    {//Метод, который переводит матрицу в стринг
        string matrixTable = null;
        for(uint i = 0; i < values.Length; i++)
        {
            for (uint j = 0; j < values[1].Length; j++)
            {
                matrixTable += (values[i][j]);
                matrixTable += " ";
            }
            matrixTable += "\n";
        }
        return matrixTable;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {//Перегрузка умножения для двух матриц
        Matrix result = new Matrix(m2.numOfRows, m1.numOfColumns, new double[m2.numOfRows, m1.numOfColumns]);
        for (uint i = 0; i < result.numOfRows; i++)
            for (uint j = 0; j < result.numOfRows; j++)
                for (uint k = 0; k < m1.numOfRows; k++)
                    result.values[i, j] += m1.values[i, k] * m2.values[k, i];
        return result;
    }
}
