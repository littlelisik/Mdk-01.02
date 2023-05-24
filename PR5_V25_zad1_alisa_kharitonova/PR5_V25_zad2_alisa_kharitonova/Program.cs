using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_V25_zad2_alisa_kharitonova
{
    //1. Удалить все символы «!», следующие за вторым предложением. В качестве текста для 
    //тестового примера(тестовых примеров) взять не менее пяти предложений.
    //вариант 25, практическая 5
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Исходный текст
            string text = "Мой друг – очень хороший человек! Я знаю, что на него можно положиться! Он всегда мне поможет, поддержит в трудную минуту! Я, конечно, отвечаю ему тем же. Мой друг никогда не предаст меня, не будет строить козни за моей спиной!";

            // Находим позицию второго предложения
            int position = text.IndexOf("!", text.IndexOf("!") + 1);

            // Удаляем все символы '!' после второго предложения
            text = text.Substring(0, position + 1) + text.Substring(position + 1).Replace("!", "");

            Console.WriteLine(text);
        }
    }
}
