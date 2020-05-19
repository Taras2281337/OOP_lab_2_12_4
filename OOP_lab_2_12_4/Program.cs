using System;

namespace OOP_lab_2_12_4
{
    public class Program
    {
        public static int Multiplication(int[] array)
        {
            int d = 1;

            bool b = false;

            foreach (int a in array)
            {
                if (a < 0)
                {
                    b = true;

                    d *= a;
                }
            }

            if (!b)
            {
                return 0;
            }

            return d;
        }

        private static int IndexMin(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[index] >= array[i])
                {
                    index = i;
                }
            }

            return index;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = IndexMin(array) + 1; i < array.Length; ++i)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);

                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Добуток вiд’ємних елементiв масиву: {0}", Multiplication(array));
            Console.WriteLine("Cумa елементiв масиву, розташованих пiсля мiнiмального елемента: {0}", Sum(array));
        }
    }
}
