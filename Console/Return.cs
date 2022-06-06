namespace Coder
{
    class Return 
    {
        public static void ListReturn(List<char>text, List<int> list, List<char> dictionary)
        {
            for (int i = 0; i < text.Count; i++)
            {
                for (int j = 0; j < dictionary.Count; j++)
                {
                    if ((text[i] == dictionary[j])) list.Add(j);
                }
            }//сделал лист в котором вместо текста- цифры, означающие порядковые номера каждой буквы
        }
    }
}
