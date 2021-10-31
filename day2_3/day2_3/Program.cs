using System;

namespace day2_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[,] a = new int[5, 5];

            Random r = new Random();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    a[i, j] = r.Next(10, 99);

          

            for (int i = 0; i < 5; i++) a[i, i] = 0; // 0 на главной диагонали

                Console.WriteLine("________________________");



            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    Console.Write("{0} ", a[i, j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
