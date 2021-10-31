using System;

namespace day2
{
    class MainClass
    {
        // public - зона видимости, тип struct
        public struct tPeople
        {

            public string n1; // поля структуры
            public string n2;
            public int year_b;

            public void AboutPeople() // метод внутри стр-ры, void - ф-ция, которая ничего не возвращает
            {

                Console.WriteLine("{0} {1}, г.р. - {2}",n1,n2,year_b);

            }


        }

        public static void Main(string[] args)
        {

            tPeople p1;

            p1.n1 = "Иванов";
            p1.n2 = "Иван";
            p1.year_b = 2002;
            p1.AboutPeople();
             
              
             
            Console.ReadKey();

        }
    }
}
