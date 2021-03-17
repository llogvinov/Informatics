using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество неизвестных переменных (= количеству уравнений)");
            int n = int.Parse(Console.ReadLine());

            float[,] A = new float[n, n];
            float[] B = new float[n];
            float[] X = new float[n];

            Console.WriteLine("Введите поочередно коэффициенты перед Х, начиная с первой строки");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = float.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Введите поочередно коэффициенты перед Y (правая часть), начиная с первой строки");
            for (int i = 0; i < n; i++)
            {
                B[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Получившаяся матрица A:");
            ShowMatrix(A);
            Console.WriteLine("Получившаяся матрица В:");
            ShowMatrix(B);
            
            Gaus(ref A, ref B);
            Console.WriteLine("Матрица А после приведеня к ступенчатому виду:");
            ShowMatrix(A);
            Console.WriteLine("Матрица В после прямого хода:");
            ShowMatrix(B);

            ReverseMove(ref A, ref B, ref X);
            Console.WriteLine("Корни системы:");
            ShowMatrix(X);

            Console.ReadLine();
        }

        private static void ShowMatrix(float[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"| {Math.Round(b[i], 4)}\t|");
            }
        }

        private static void ShowMatrix(float[,] a)
        {
            for (int i = 0; i < Math.Sqrt(a.Length); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < Math.Sqrt(a.Length); j++)
                {
                    Console.Write($"{Math.Round(a[i, j], 4)}\t");
                }
                Console.WriteLine("|");
            }
        }

        private static void Gaus(ref float[,] a, ref float[] b)
        {
            float d;
            for (int k = 0; k < b.Length - 1; k++)
            {
                for (int i = k + 1; i < b.Length; i++)
                {
                    d = a[i, k] / a[k, k];
                    for (int j = k; j < b.Length; j++)
                    {
                        a[i, j] = a[i, j] - a[k, j] * d;
                    }
                    b[i] = b[i] - b[k] * d;
                }
            }
        }

        static void ReverseMove(ref float[,] a, ref float[] b, ref float[] x)
        {
            float s;
            for (int k = b.Length - 1; k >= 0; k--)
            {
                s = 0;
                for (int i = k; i <= b.Length - 1; i++)
                {
                    s += a[k, i] * x[i];
                }
                if (a[k, k] == 0)
                {
                    Console.WriteLine("Элемент A", k, ',', k, "= 0");
                    Environment.Exit(0);
                }
                x[k] = (b[k] - s) / a[k, k];
            }
        }
    }
}
