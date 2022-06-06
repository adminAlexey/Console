namespace Coder// что необходимо для работы: каждый раз узнаю какой по счету символ, его процент уникальности,
{
    class Interval
    {
        public static void IntervalCoder(List <int> list, List<char> dictionary,out double left,out double right)
        {
            List <double> vs = new List <double> ();
            left = 0;
            right = Math.Pow(10.0, list.Count);
            double result = 0;//10
            for (int i = 0; i < dictionary.Count; i++)
            {
                double count = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (i==list[j])count++;
                }
                vs.Add(count / list.Count);
                //Console.WriteLine($"кол-во {dictionary[i]} = {vs.Last()}");//vs список содержит в себе информацию о уникальности
            }
            
            for (int i = 0;i < list.Count; i++)
            {
                double d = 0;
                double dd = 0;
                Console.WriteLine($"на {i} итерации  {left} - {right}"); //для проверки
                for (int j = 0;j < dictionary.Count; j++)
                {
                    dd = vs[j];
                    if (list[i] == j)
                    {
                        result = (right - left);
                        break;
                    }
                    d += vs[j];
                }

                Console.WriteLine(); //сохранил для проверки
                left += result * (d);
                right -= result*(1-(d+dd));
                result /= 10;
                Console.WriteLine($"шаг= {result}");
            }
        }
    }
}
