using System;
using VectorSpace;

class App
{
    static void Main(string[] args)
    {
        Matrix[] matricies = new Matrix[2];
        for (uint i = 0; i < 2; i++)
        {//В этом цикле происходит ввод и вывод матриц.
            UInt32 rows = 0,
            columns = 0;
            Console.WriteLine("Сколько строк будет в матрице #", i ++, "? ");
            rows = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Сколько строк будет в матрице #", i ++, "? ");
            columns = Convert.ToUInt32(Console.ReadLine());
            double[,] values = new double[rows, columns];
            for (UInt32 j = 0; j < rows; j++)
                for (UInt32 k = 0; k < columns; k++)
                {
                    Console.Write("Введите значение #", j + 1, " ", i + 1, "\n");
                    values[j, k] = Convert.ToDouble(Console.ReadLine());
                }
            matricies[i] = new Matrix(rows, columns, values);
            foreach (double value in matricies[i].GetValues())
                Console.WriteLine(value);
        }
        Matrix multiResult = matricies[0] * matricies[1]; //Тестируем умножение двух матриц.
            foreach(double value in multiResult.GetValues())
                Console.WriteLine(value);
    }
}
