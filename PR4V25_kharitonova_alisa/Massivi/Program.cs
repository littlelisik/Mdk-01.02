using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massivi
{
    internal class Program
    {
        static void Main(string[] args)
            //number 25 Kharitonova Alisa
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Объявляем размеры матрицы NxM и саму матрицу
            int N, M;
            int[,] matrix;

            // Вводим размеры матрицы с клавиатуры
            Console.WriteLine("Введите количество строк матрицы:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы:");
            M = int.Parse(Console.ReadLine());

            // Создаем матрицу с заданными размерами
            matrix = new int[N, M];

            // Заполняем матрицу случайными числами
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rnd.Next(1, 100);
                }
            }

            // Выводим исходную матрицу на экран
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Проходим по каждой строке матрицы
            for (int i = 0; i < N; i++)
            {
                // Находим минимальный элемент в строке
                int min = matrix[i, 0];
                int minIndex = 0;
                for (int j = 1; j < M; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minIndex = j;
                    }
                }
                // Перемещаем минимальный элемент в первый столбец, зеркально относительно границ матрицы
                matrix[i, minIndex] = matrix[i, 0];
                matrix[i, 0] = min;
                matrix[i, M - 1 - minIndex] = matrix[i, M - 1];
                matrix[i, M - 1] = min;
            }

            // Выводим полученную матрицу на экран
            Console.WriteLine("Результирующая матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
