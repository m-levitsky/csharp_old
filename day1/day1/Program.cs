using System;

namespace day1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s1 = " \"приветик\" ";

            Console.WriteLine("це число - \a{0},а це рядок - {1}",12,s1); // \а - звук.сигнал
            Console.WriteLine("ще раз - \v{1}", 12, s1); // \v - верт.табуляция

            // @ - буквальная строка
            string s2 = @"a
            b
                         c";

            Console.WriteLine(s2);

            int a = 12;
            int b = 18;
            int c = a & b; // операция И 
            int d = a | b; // оп. ИЛИ 
            int e = a ^ b; // оп. исключающего ИЛИ

            // https://metanit.com/sharp/tutorial/2.24.php

            Console.WriteLine("c = {0}, d = {1}, e = {2}",c,d,e);

            #region zadacha

            int w = 236;
            int mask = 1 << 3;
            int res = mask & w;
            res = res >> 3;

            int mask2 = 8;
            int c2 = mask2 | w;

            Console.WriteLine(res);
            Console.WriteLine(c2);

            #endregion

            Console.ReadKey(); 
        }
    }
}
