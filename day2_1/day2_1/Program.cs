using System;

namespace day2_1
{
    class MainClass
    {

        enum LightMachine // светофор, enum - перечисление

        { LmRed, LmYellow, LmGreen }

        enum LightMachine1 : int
        {
            LmRed = 1,
            LmYellow = 2,
            LmGreen = 3
        }


        public static void Main(string[] args)
        {

            LightMachine p = LightMachine.LmRed;

            LightMachine p1 = (LightMachine)1; // LmYellow


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine(p);
            Console.WriteLine(p1);

          
        Console.ReadKey();
        }
    }
}
