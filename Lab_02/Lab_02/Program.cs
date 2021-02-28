using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> x_All = new List<double>();
            List<double> y_RK_4 = new List<double>();

            double x0 = 0.0f;
            double y0 = 1.0f;
            float h0 = 1.0f;
            int m = 10;

            RK_4(x0, y0, h0, m, ref x_All, ref y_RK_4);
            List<double> y_PC = y_RK_4;
            List<double> y_Ad = y_RK_4;
 
            // Вывод таблицы значений х, у для метода Рунге_Кутты
            Console.WriteLine("Метод Рунге-Кутты 4-го порядка:\n");
            for (int i = 0; i < Math.Min(x_All.Count(), y_RK_4.Count()); i++)
            {
                Console.WriteLine("{0,3} | {1}", x_All[i], y_RK_4[i]);
            }

            for (int i = 3; i < Math.Min(x_All.Count(), y_PC.Count()) - 1; i++)
            {
                Predictor(h0, m, x_All, ref y_PC, i);
                Corrector(h0, m, x_All, ref y_PC, i);
            }

            // Вывод таблицы значений х, у для метода прогноза и коррекции
            Console.WriteLine("\nМетод прогноза и коррекции:\n");
            for (int i = 0; i < Math.Min(x_All.Count(), y_PC.Count()); i++)
            {
                Console.WriteLine("{0,3} | {1}", x_All[i], y_PC[i]);
            }

            for (int i = 3; i < Math.Min(x_All.Count(), y_Ad.Count()) - 1; i++)
            {
                Adams(h0, m, x_All, ref y_Ad, i);
            }

            // Вывод таблицы значений х, у для метода Адамса
            Console.WriteLine("\nМетод Адамса:\n");
            for (int i = 0; i < Math.Min(x_All.Count(), y_PC.Count()); i++)
            {
                Console.WriteLine("{0,3} | {1}", x_All[i], y_Ad[i]);
            }

            Console.Read();
        }

        // Функция f(x, y)
        static double F(double x, double y)
        {
            return (y * Math.Cos(x));
        }

        // Расчет значений у методом Рунге-Кутты, изменяет массив значений х и у
        static void RK_4(double x, double y, float h0, float m, ref List<double> x_all, ref List<double> y_rk_4)
        {
            double k0, k1, k2, k3, dy = 0.0d;
            float h = h0 / m;

            while (x <= h0)
            {
                x_all.Add(x);
                y_rk_4.Add(y);

                k0 = h * F(x, y);
                k1 = h * F(x + h / 2, y + k0 / 2);
                k2 = h * F(x + h / 2, y + k1 / 2);
                k3 = h * F(x + h, y + k2);

                x = Math.Round(x + h, 1);
                dy = (k0 + 2 * k1 + 2 * k2 + k3) / 6.0f;
                y += dy;
            } 
        }

        // Предиктор
        static void Predictor(float h0, int m, List<double> x_all, ref List<double> y_pc, int i)
        {
            float h = h0 / m;
            y_pc[i + 1] = y_pc[i] + h / 24 * (55 * F(x_all[i], y_pc[i]) - 59 * F(x_all[i - 1], y_pc[i - 1])
                + 37 * F(x_all[i - 2], y_pc[i - 2]) - 9 * F(x_all[i - 3], y_pc[i - 3]));
        }

        // Корректор
        static void Corrector(float h0, int m, List<double> x_all, ref List<double> y_pc, int i)
        {
            float h = h0 / m;
            y_pc[i + 1] = y_pc[i] + h / 24 * (9 * F(x_all[i + 1], y_pc[i + 1]) - 19 * F(x_all[i], y_pc[i])
                -5 * F(x_all[i - 1], y_pc[i - 1]) + F(x_all[i - 2], y_pc[i - 2]));
        }

        // Метод Адамса
        static void Adams(float h0, int m, List<double> x_all, ref List<double> y_ad, int i)
        {
            double d1_f, d2_f, d3_f;
            float h = h0 / m;

            d1_f = F(x_all[i], y_ad[i]) - F(x_all[i - 1], y_ad[i - 1]);
            d2_f = F(x_all[i], y_ad[i]) - 2 * F(x_all[i - 1], y_ad[i - 1]) + 
                F(x_all[i - 2], y_ad[i - 2]);
            d3_f = F(x_all[i], y_ad[i]) - 3 * F(x_all[i - 1], y_ad[i - 1]) + 
                3 * F(x_all[i - 2], y_ad[i - 2]) - F(x_all[i - 3], y_ad[i - 3]);

            y_ad[i + 1] = y_ad[i] + h * y_ad[i] + Math.Pow(h, 2) / 2 * d1_f +
                5 * Math.Pow(h, 3) / 12 * d2_f + 3 * Math.Pow(h, 4) / 8 * d3_f;
        }

    }
}
