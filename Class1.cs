using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_char_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "модераторы киберфорума - самые няшные люди в мире";

            Console.WriteLine("нажмите на букву, которую вы хотите найти в тексте");
            char chr = Console.ReadKey().KeyChar;//если надо вывести все буквы текста и их количество, то эту строчку надо убрать

            var result = from c in text
                         group c by c into groupedChar
                         where groupedChar.Key == chr //если надо вывести все буквы текста и их количество, то эту строчку надо убрать
                         select new { instance = groupedChar.Key, instanceCount = groupedChar.Count() };

            foreach (var item in result)
            {
                Console.WriteLine("\nБуква: " + item.instance + ". Количество вхождений в текст: " + item.instanceCount);
            }

            Console.ReadLine();
        }
    }
}