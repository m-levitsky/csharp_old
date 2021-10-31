using System;

namespace day_4
{
    class MainClass 
    {

        delegate double Calc(int a, int b);


        static double f_00(int a, int b)
        {
            return 0;
        }

        static double f_01(int a, int b)
        {
            return a + b;
        }

        static double f_02(int a, int b)
        {
            return a * b;
        }

        static double f_03(int a, int b)
        {
            return (double)a / b;
        }



        public static void Main(string[] args)
        {
            Console.Write("enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter method [1 +,2 *,3 /]: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Calc myCalc;

            if (m == 1)
            {
                myCalc = f_01;
            }
            else if (m == 2)
            {
                myCalc = f_02;
            }
            else if (m == 3)
            {
                myCalc = f_03;
            }
            else
            {
                myCalc = f_00;
            }

            double res = myCalc(a, b);

            Console.WriteLine("result: {0}", res);


        }
    }
}
