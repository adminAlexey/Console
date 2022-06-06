namespace Coder
{
    class Delta
    {
        public static void DeltaCoder(List<int> list)
        {
            int last = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int tmp = list[i];
                list[i] -= last;
                last = tmp;
            }                                    //дельта кодирование
        }
    }
}
