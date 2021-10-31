using System;

namespace day3
{
    class MainClass
    {
        #region step_01

        static public void func_01()
        {
            Console.WriteLine("call 01");
            return;
        }

        static public int func_02()
        {
            Console.WriteLine("call 02");
            return 0; // конец функции, возвращает значение типа int
        }

        static public int func_001(int a, int b) // int a, int b - параметры
        {
            // by value
            a += 10; // a = a + 10
            return a + b;
        }

        static public int func_001(ref int a, ref int b)
        {
            // by reference
            a += 10; 
            return a + b;
        }

        static public int func_05(ref int a, out int b) // b - только возвращаемая
        {
            // b needs value
            b = 99; // !!!
            a += 10;
            return a + b;
        }

        #endregion

        public static void Main(string[] args)
        {
            func_01(); // можно только вызвать
            func_02();

            int f = func_02();
            if (func_02() == 3) Console.WriteLine("..."); // примеры использования ф-ции

            #region func_03

            Console.WriteLine("_______________________________________");

            int a = 100;
            int b = 200;
            int c = 0;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            c = func_001(a,b);

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c); // a = 100 ( а не 110) - передача по значению

            #endregion

            c = func_001(ref a,ref b); // a = 110 - передача по ссылке
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            c = func_05( ref a, out b);
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            // две функции могут иметь одно имя, если у них разный тип (или кол-во параметров) - перегрузка функции

          
            Console.ReadKey();
        }


    }
}
