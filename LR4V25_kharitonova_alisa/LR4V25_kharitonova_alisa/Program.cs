using System;
using System.Text;

class Program
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;
        int size;
        bool isValidSize = false;

        // Ввод размерности массива и проверка на корректность
        do
        {
            Console.Write("Введите размерность массива: ");
            string input = Console.ReadLine();

            // Попытка преобразования введенной строки в число
            if (int.TryParse(input, out size))
            {
                // Проверка на допустимый диапазон значений
                if (size >= 0 && size <= 10)
                {
                    isValidSize = true;
                }
                else
                {
                    Console.WriteLine("Ошибка: размерность должна быть от 0 до 10. Повторите ввод.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Повторите ввод.");
            }
        } while (!isValidSize);

        // Создание и заполнение массива факториалами индексов
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = CalculateFactorial(i);
        }

        // Вывод массива на экран
        Console.WriteLine("Массив факториалов:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"array[{i}] = {array[i]}");
        }
    }

    // Функция для вычисления факториала числа
    static int CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}