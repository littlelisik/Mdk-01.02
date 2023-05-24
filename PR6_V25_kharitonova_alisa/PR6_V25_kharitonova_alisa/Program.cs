using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Харитонова Алиса, 25 вариант. Задание:
        // В текстовый файл по строкам записано астрономическое время в формате «чч:мм:сс».
        // К каждому из значений прибавляется случайное количество секунд из диапазона от одной минуты до пяти часов.
        // В новый файл записать в формате астрономического времени сгенерированное случайное значение,
        // после которого через пробел указать, произошёл ли переход через сутки или нет.
        // Для решения задачи не использовать тип DateTime и прочие типы, связанные с датой/временем.

        // Название исходного и нового файлов
        string inputFileName = "astronomical_time.txt";
        string outputFileName = "generated_time.txt";

        try
        {
            // Читаем исходный файл с астрономическим временем
            string[] lines = File.ReadAllLines(inputFileName);

            // Генерируем случайное значение и записываем в новый файл
            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                Random random = new Random();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');

                    int hours = int.Parse(parts[0]);
                    int minutes = int.Parse(parts[1]);
                    int seconds = int.Parse(parts[2]);

                    // Генерируем случайное количество секунд
                    int randomSeconds = random.Next(60, 60 * 60 * 5);

                    // Прибавляем случайное количество секунд к текущему времени
                    int newSeconds = seconds + randomSeconds;
                    int newMinutes = minutes + newSeconds / 60;
                    int newHours = hours + newMinutes / 60;

                    // Проверяем, произошел ли переход через сутки
                    bool isNextDay = newHours >= 24;
                    if (isNextDay)
                    {
                        newHours %= 24;
                    }

                    // Форматируем результат в строку астрономического времени
                    string generatedTime = $"{newHours:D2}:{newMinutes % 60:D2}:{newSeconds % 60:D2}";

                    // Записываем результат в новый файл
                    writer.WriteLine($"{generatedTime} {(isNextDay ? "Переход" : "Нет перехода")}");
                }
            }

            Console.WriteLine("Генерация завершена. Результат записан в файл generated_time.txt.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
