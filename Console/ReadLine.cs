namespace Coder
{
    class ReadLine
    {
        public static void Metod()
        {
            Console.WriteLine("Reading the contents from the file: \n");
            StreamReader myStreamReader = File.OpenText(@"C:\Users\Alexey\source\repos\Console\Console\Муму.txt");
            int count = System.IO.File.ReadAllLines(@"C:\Users\Alexey\source\repos\Console\Console\Муму.txt").Length; // количество строк в файле
            string[] newText = new string[count]; // создаем массив нужной размерности
            for (int i = 0; !myStreamReader.EndOfStream; i++)
            {
                newText[i] = myStreamReader.ReadLine();
            }
            Console.WriteLine(newText[0]);
            myStreamReader.Close();
            Console.ReadKey();
        }
    }
}
