namespace Coder
{
    class DeltaDec
    {
        public static void DeltaDecoder(List <int> list)
        {
            int last = 0;
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += last;
                last = list[i];
            }
        }
    }
}
