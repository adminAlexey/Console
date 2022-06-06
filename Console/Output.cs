namespace Coder
{
    class Output
    {
        public static void Vivod(List<char> text, List<char> dictionary)
        {
            dictionary = text.Distinct().ToList();
            dictionary.Sort();
            for (int i = 0; i < dictionary.Count; i++)
            {
                int count = 1;
                for (int j = 0; j < text.Count; j++)
                    if (dictionary[i] == text[j]) count++;

                Console.WriteLine($"* {dictionary[i]} * ={dictionary[i] - '0'} кол-во {count} номер в листе {i}");
            }                                    //вывод элемента, его количества и его номер в таблице аски
        }
    }
}
