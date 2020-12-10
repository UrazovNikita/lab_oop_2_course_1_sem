
using System;

namespace Laba9
{
    class Program
    {

        static void Main(string[] args)
        {

            User stu1 = new User(1000);
            stu1.Solution += DisplayMessage;
            Console.WriteLine($"Студент 1. ЗП составляет: {stu1.Money}");
            stu1.rankUp();
            Console.WriteLine($"Студент 1 повышен. ЗП составляет: {stu1.Money}");
            stu1.fine();
            Console.WriteLine($"Студент 1 оштрафован. ЗП составляет: {stu1.Money}");
            Console.WriteLine();

            User stu2 = new User(1000);
            stu2.Solution += DisplayMessage;
            Console.WriteLine($"Студент 2. ЗП составляет: {stu2.Money}");
            stu2.rankUp();
            Console.WriteLine($"Студент 2 повышен. ЗП составляет: {stu2.Money}");
            Console.WriteLine();

            User tok1 = new User(2000);
            tok1.Solution += DisplayMessage;
            Console.WriteLine($"Токарь 1. ЗП составляет: {tok1.Money}");
            tok1.rankUp();
            Console.WriteLine($"Токарь 1 повышен. ЗП составляет: {tok1.Money}");
            Console.WriteLine();

            User tok2 = new User(2000);
            tok2.Solution += DisplayMessage;
            Console.WriteLine($"Токарь 2. ЗП составляет: {tok2.Money}");
            tok2.fine();
            Console.WriteLine($"Токарь 2 оштрафован. ЗП составляет: {tok2.Money}");
            Console.WriteLine();


            void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }


            string str = "A simple string !";
            Func<string, char, string> retF = AddSymb;
            retF += RemoveSymb;
            retF += DownSymb;
            retF += UpSymb;

            str = Operation(str, 'A', retF);

            Console.WriteLine();





            string strrr = "Vveli";
            User vvod = new User(2000);
            tok2.Solution += DisplayMessage;
            vvod.vvvod(strrr);



            if (strrr == null)
            {
                Console.WriteLine("Ввод пустой");
            }
            else
            {
                Console.WriteLine($"Вы ввели: {strrr}");
            }

            Console.ReadKey();
        }
        static string Operation(string str, char symb, Func<string, char, string> retF)
        {
            if (str != null)
                str = retF(str, symb);
            return str;
        }


        public static string RemoveSymb(string a, char symb)
        {
            while (a.IndexOf(symb) >= 0)
                a = a.Remove(a.IndexOf(symb), 1);
            Console.WriteLine($"Symbol {symb} has been removed");
            Console.WriteLine(a);
            return a;
        }

        public static string AddSymb(string a, char symb)
        {
            a = a + symb;
            Console.WriteLine($"Symbol {symb} has been added");
            Console.WriteLine(a);
            return a;
        }
        public static string UpSymb(string a, char symb)
        {
            a = a.Replace(symb, a.Substring(a.IndexOf(symb)).ToUpper()[0]);
            Console.WriteLine($"Symbol {symb} has been upped");
            Console.WriteLine(a);
            return a;
        }
        public static string DownSymb(string a, char symb)
        {
            a = a.Replace(symb, a.Substring(a.IndexOf(symb)).ToLower()[0]);
            Console.WriteLine($"Symbol {symb} has been downed");
            Console.WriteLine(a);
            return a;
        }
        public static string AddDot(string a, char dot)
        {
            Console.WriteLine("Dot has been added to this string");
            Console.WriteLine(a);
            return a + '.';
        }
    }
}
}
