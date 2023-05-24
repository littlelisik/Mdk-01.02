using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_V25_kharitonova_alisa
{
    //2. Вырезать из текста символы, начиная с третьего в количестве, равном разнице между 
    //количеством символов в словах(взятых из всего текста) с максимальной и минимальной
    //длинами.В качестве текста для тестового примера(тестовых примеров) взять не менее пяти предложений.
    //вариант 25, практическая 5
    internal class Program
    {
        static void Main()
        {
            //2
            Console.OutputEncoding = Encoding.UTF8;
            string text = "Мой друг – очень хороший человек. Я знаю, что на него можно положиться. Он всегда мне поможет, поддержит в трудную минуту. Я, конечно, отвечаю ему тем же. Мой друг никогда не предаст меня, не будет строить козни за моей спиной.";

            string[] words = text.Split(' ');
            int maxLen = 0;
            int minLen = int.MaxValue;
            foreach (string word in words)
            {
                int len = word.Length;
                if (len > maxLen)
                {
                    maxLen = len;
                }
                if (len < minLen)
                {
                    minLen = len;
                }
            }

            int numToRemove = maxLen - minLen - 2;

            if (numToRemove > 0)
            {
                string newText = "";
                int count = 0;
                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                    {
                        count++;
                        if (count > 2 && numToRemove > 0)
                        {
                            numToRemove--;
                            continue;
                        }
                    }
                    newText += c;
                }
                text = newText;
            }

            Console.WriteLine(text);
        }

    }
}