using System;

namespace day3_factorial
{
    class MainClass
    {

         public static int fact(int a)
        {
            int r = 1;
            for(int i = 1; i <= a; i++) r *= i;
            return r;
        }

        // с помощью рекурсии :
        // public static int fact(int a)
        // {
        //    if (a == 1) return 1;
        //    return a * fact(a - 1);
        // }


        public static void Main(string[] args)
        {

            Console.Write("Enter value: ");
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);

            int r = fact(a);

            Console.WriteLine("\n{0}!={1}",a,r);
        }
    }
}
