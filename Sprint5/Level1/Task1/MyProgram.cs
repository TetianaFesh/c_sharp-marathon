using System;
using System.Collections.Generic;

namespace Sprint5
{
    public class MyProgram
    {
        public static void Position(List<int> numbers)
        {
            for (int i = 1; i <= numbers.Count; i++)
            {
                if (numbers[i] == 5)
                    Console.WriteLine(i + 1);
            }
        }

        public static void Remove(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 20)
                {
                    numbers.RemoveAt(i);
                    Console.WriteLine(i);
                    i--;
                }
            }
            PrintCollection(numbers);
        }

        public static void PrintCollection(List<int> numbers)
        {
            foreach (var n in numbers)
            {
                Console.WriteLine(n + " ");
            }
        }

        public static void Insert(List<int> numbers)
        {
            if (numbers.Count > 3)
            {
                numbers.Insert(2, -5);
                if (numbers.Count > 6)
                {
                    numbers.Insert(5, -6);
                    if (numbers.Count > 8)
                       numbers.Insert(7, -7);
                }
            }
            PrintCollection(numbers);
        }

        public void Sort(List<int> numbers)
        {
            int x;
            for (int i = 1; i < numbers.Count; i++) /* зовнішній цикл */
            {
                for (int j = numbers.Count - 1; j >= i; j--) /* внутрішній цикл */
                {
                    if (numbers[j] < numbers[j - 1]) /* умова перебору */
                    {
                        /* міняємо місцями значення масиву*/

                        /* зберігаємо значення більшого елементу в змінну */
                        x = numbers[j - 1];
                        /* переміщамо менший елемент на одну позицію вліво */
                        numbers[j - 1] = numbers[j];
                        /* більший елемент переміщаємо на одну позицію вправо */
                        numbers[j] = x;
                    }
                }
            }
            PrintCollection(numbers);
        }
    }
}
