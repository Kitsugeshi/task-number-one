using System;

namespace task_number_one
{
    class ReshetoEratosfena
    {
        static void Main(string[] args)
        {
            int n, j = 0;
            Console.WriteLine("Введите число n:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = i;
            }

            a[1] = 0;
            int m = 2;

            while (m < n)
            {
                if (a[m] != 0)
                    j = m * 2;
                while (j < n)
                {
                    a[j] = 0;
                    j = j + m;
                }
                m += 1;
            }

            foreach (int x in a)
            {
                if (x != 0)
                    Console.Write(x + " ");
            }

            Console.ReadKey();
        }
    }
}
