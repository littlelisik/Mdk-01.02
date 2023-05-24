using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_V25_kharitonova_Alisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Пункты меню
            string[] menuItems = { "Kvas", "Mirinda", "Coca-cola", "Sprite", "Fanta", "Выход" };

            while (true)
            {
                // Выводим меню на экран
                Console.WriteLine("Выберите напиток из меню:");
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }

                // Ждем выбора пользователя
                int choice;
                bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (isValidChoice && choice >= 1 && choice <= menuItems.Length)
                {
                    // Получаем выбранный пункт меню
                    string selectedDrink = menuItems[choice - 1];

                    // Выводим сообщение о выбранном напитке с зеленым цветом шрифта
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы выбрали {selectedDrink}. Надеюсь, вы освежитесь!");
                    Console.ResetColor();

                    if (selectedDrink == "Выход")
                    {
                        // Если выбран пункт "Выход", завершаем программу
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                }

                Console.WriteLine();
            }
        }
    }
}
