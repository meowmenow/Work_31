using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ИСП-23, Бирюков Георгий, 30.11.2021
//Сформировать одномерный массив из максимальных элементов столбцов матрицы.

namespace Адовые_коды__10__Практическая_намбер_тен_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int[,] matras = new int[n, n]; // Ввод матрицы
            int[] masos = new int[n]; // Ввод массива
            Random r = new Random(); // Ввод рандома

            /// Вывод исходной матрицы
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matras[i, j] = r.Next(-10, 11); // Ввод границ матрицы
                    Console.Write(matras[i, j].ToString() + "\t"); // Вывод

                }
                Console.WriteLine();
            }

            /// Вывод массива из максимальных элементов в столбцах матрицы
            Console.WriteLine("Массив из максимальных элементов в каждом столбце:");
            for (int j = 0; j < n; j++)
            {
                int max = int.MinValue;
                for (int i = 0; i < n; i++)
                {
                    if (matras[i, j] > max)
                    {
                        max = matras[i, j];
                    }
                }
                masos[j] = max;
                Console.Write(masos[j].ToString() + "\t"); // Вывод
            }
            Console.ReadKey(); // Пауза
        }
    }
}
