namespace Coder//53229, лист текст, лист 2 алфавит отсортированный, лист 1
{ 
    class Coder
    {

        static void Main()
        {
            List<char> text = new List<char>();         //
            List<char> dictionary = new List<char>();   // Объявили необходимое для работы кол-во листов
            List<int> list = new List<int>();           //

            double left;
            double right;

            string file = "";

            using (StreamReader fs = new StreamReader(@"C:\Users\Alexey\source\repos\Console\Console\Муму1.txt"))
            {
                while (true)
                {
                    // Читаем строку из файла во временную переменную.
                    string temp = fs.ReadLine();
                    // Если достигнут конец файла, прерываем считывание.
                    if (temp == null) break;
                    // Пишем считанную строку в итоговую переменную.
                    file += temp;
                }
            }

            //поместили текст в лист
            text = file.ToList();                       
            dictionary = text.Distinct().ToList();
            dictionary.Sort();//получили отсортированный алфавит

            foreach (char c in text) Console.Write(c);
            Console.WriteLine();

            //вывод словаря
            Output.Vivod(text, dictionary);
            Console.WriteLine();

            //лист в котором текст в виде цифр
            Return.ListReturn(text, list, dictionary);  
            foreach (int c in list) Console.Write($"{c} ");
            Console.WriteLine();

            //дельта кодирование
            //Delta.DeltaCoder(list);                     
            //Console.WriteLine();
            //foreach (int c in list) Console.Write($"{c} ");

            //дельта декодирование
            //DeltaDec.DeltaDecoder(list);                
            //Console.WriteLine();
            //foreach (int c in list) Console.Write($"{c} ");

            //интервальное кодирование
            Interval.IntervalCoder(list, dictionary, out left, out right);
            Console.WriteLine();
            Console.WriteLine($"левая граница интервала = {left} правая граница интервала = {right}");

        }
    }
}