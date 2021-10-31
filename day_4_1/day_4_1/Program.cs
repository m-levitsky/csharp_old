using System;

namespace day_4_1
{
    class MainClass
    {

        static void Swap(int[] a,int i, int j)
        {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }


        static void arrOut(int[] a)
                {
            for (int i = 0; i < a.Length; i++)
          
                Console.Write("{0} ",a[i]);
                Console.WriteLine();
                }


        public static void Main(string[] args)
        {

            int[] array = new int[20];

            Random rand = new Random();

            for (int i = 0; i < 20; i++) array[i] = rand.Next(0, 50);

            arrOut(array);


            for (int i = 0; i < 20; i++)
            {
                for (int j = i; j < 20; j++)
                {
                    if (array[i] > array[j]) Swap(array, i, j); 
                }
            }

            arrOut(array);
        }
    }
}
