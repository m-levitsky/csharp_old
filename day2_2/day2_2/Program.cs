using System;

namespace day2_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //int[] a1 = { 2, 55, 6, 77, 3 };

            //int[] a2;
            //// to do
            //a2 = new int[10];

            //int[] a3 = new int[10];

            int[] a = new int[20];
            Random r = new Random();
            //Random - тип класса, r - инстанс (экземпляр) класса
            // Random() - конструктор для создания экземпляра

            int i = 0;
            m: // метка
            a[i++] = r.Next(10,99);
            if (i <= 19) goto m; // не цикл

            //for(int j = 0; j < 20; j++)
            for (int j = 0; j < a.Length; j++)
            {
                if (j == 10) break;
                Console.Write("{0} ", a[j]);
            }
            Console.WriteLine();

            i = 0;
            while (i <= 19)
            {
                if (i == 10)
                {
                    i++;
                    continue; //пропустит 10 элемент
                }

                Console.Write("{0} ", a[i++]); // i++ != ++i
            }
            Console.WriteLine();


            i = 0;
            do
                Console.Write("{0} ", a[i++]);
            while (i <= 19);
            Console.WriteLine();
            // цикл, которого не было в с++

            foreach (int item in a) // item - имя переменной, in a - в массиве а
            {
                Console.Write("{0} ", item); // item - read only (нельзя присвоить значение)
            }


            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
