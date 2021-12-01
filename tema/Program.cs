using System;
using System.Collections.Generic;
using System.Linq;

namespace temaLabFP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ex1(0,"fahrenheit");
            ex2("modul");
            ex3(2,4,7);
            ex4(16);
            ex5(1,200);
            ex6(10,20);
            ex8(8);
            ex9(13,4);
            ex10(14);
            ex11(6,12);
            ex12();
            ex14();
            ex15(3);
            ex16(7, 8);
            ex17(1,2,3,4);
            ex18();
            ex19();
            ex20();*/
        }

        private static void ex20()
        {
            Console.WriteLine("ex20");
            int nr = 1, c = 0, s = 0;
            while (nr != 0)
            {
                bool a = int.TryParse(Console.ReadLine(), out int n);
                nr = n;
                if (n != 0)
                {
                    c++;
                    s += n;
                }
            }
            float aritmetica = (float)s / c;
            Console.WriteLine("Media aritmetica a sirului este: " + aritmetica);
        }

        private static void ex19()
        {
            Console.WriteLine("ex19");
            Console.WriteLine("a = ");
            bool n1 = int.TryParse(Console.ReadLine(), out int nr1);
            Console.WriteLine("b = ");
            bool n2 = int.TryParse(Console.ReadLine(), out int nr2);
            Console.WriteLine("c = ");
            bool n3 = int.TryParse(Console.ReadLine(), out int nr3);
            Console.WriteLine("Ce doriţi să calculăm ? Aria sau perimetrul?");
            string a = Console.ReadLine();
            int p = nr1 + nr2 + nr3;
            double sp = (double)p / 2;
            if (a == "perimetrul")
            {
                Console.WriteLine(p);
            }
            else if (a == "aria")
            {
                double aria = (double)Math.Sqrt(sp * (sp - nr1) * (sp - nr2) * (sp - nr3));
                if (Double.IsNaN(aria))
                {
                    Console.WriteLine("Datele nu sunt corecte");
                }
                else
                {
                    Console.WriteLine(aria);
                }
            }
        }

        private static void ex18()
        {
            Console.WriteLine("ex18");
            Console.WriteLine("a = ");
            bool n1 = int.TryParse(Console.ReadLine(), out int nr1);
            Console.WriteLine("b = ");
            bool n2 = int.TryParse(Console.ReadLine(), out int nr2);
            Console.WriteLine("Ce doriţi să calculăm ? Media aritmetică (1) sau geometrică (2)?");
            bool a = int.TryParse(Console.ReadLine(), out int nr);
            if (nr != 1 && nr != 2)
            {
                if (nr < 0)
                {
                    Console.WriteLine("error");
                }
                Console.Beep();
            }
            else if (nr == 1)
            {
                double aritmetica = (double)(nr1 + nr2) / 2;
                Console.WriteLine("Media aritmetica este: " + aritmetica); ;
            }
            else if (nr == 2)
            {
                double geometrica = (double)Math.Sqrt(nr1 * nr2);
                Console.WriteLine("Media geometrica este: " + geometrica); ;
            }
        }

        private static void ex17(int x0, int t0, int x, int t)
        {
            Console.WriteLine("ex17");
            double v = (double)(x - x0) / (t - t0);
            Console.WriteLine("Viteza este:" + v + " m/s");
        }

        private static void ex16(int f, int r)
        {
            Console.WriteLine("ex16");
            Console.WriteLine(f * r);
        }

        private static void ex15(int nr)
        {
            Console.WriteLine("ex15");
            int f = 1;
            for (int i = 1; i <= nr; i++)
            {
                f *= i;
            }
            Console.WriteLine(f);
        }

        private static void ex14()
        {
            Console.WriteLine("ex14");
            int nr = 1, s = Int32.MaxValue, b = Int32.MinValue;
            while (nr != 0)
            {
                bool a = int.TryParse(Console.ReadLine(), out int n);
                nr = n;
                if (n != 0)
                {
                    if (n > b)
                    {
                        b = n;
                    }
                    else if (n < s)
                    {
                        s = n;
                    }
                }
            }
            Console.WriteLine("Cel mai mic numar este " + s + ", iar cel mai mare numar este " + b);
        }

        private static void ex12()
        {
            Console.WriteLine("ex12");
            double c;
            for (int f = 0; f <= 300; f++)
            {
                c = (double)(f - 32) * 5 / 9;
                Console.WriteLine("Celsius: " + c + " | Fahrenheit: " + f);
            }
        }

        private static void ex11(int nr1, int nr2)
        {
            Console.WriteLine("ex11");
            int a = nr1, b = nr2;
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            if (a == 1)
            {
                Console.WriteLine(nr1 + " si " + nr2 + " sunt prime intre ele");
            }
            else
            {
                Console.WriteLine(nr1 + " si " + nr2 + " nu sunt prime intre ele");
            }
        }

        private static void ex10(int nr)
        {
            Console.WriteLine("ex10");
            string result = "";
            for (int i = 1; i <= nr; i++)
            {
                bool prim = true;
                for (int j = 1; j < i; j++)
                {
                    if (j != 1)
                    {
                        if (i % j == 0)
                        {
                            prim = false;
                        }
                    }
                }
                if (prim == true)
                {
                    result += i + " ";
                }

            }
            Console.WriteLine(result);
        }

        private static void ex9(int nr1, int nr2)
        {
            Console.WriteLine("ex9");
            int m, d;
            int a = nr1, b = nr2;
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            d = a;
            m = nr1 * nr2 / d;
            Console.WriteLine("Cel mai mare divizor comun: " + d + ", cel mai mic multiplu comun: " + m);
        }

        private static void ex8(int nr)
        {
            Console.WriteLine("ex8");
            List<int> arr = new List<int> { };
            for (int i = 1; i <= nr; i++)
            {
                if (nr % i == 0)
                {
                    arr.Add(i);
                }
            }

            double aritmetica = 0, geometrica = 1, armonica = 0;
            foreach (int item in arr)
            {
                aritmetica += item;
                geometrica *= item;
                armonica += (double)1 / item;
            }
            aritmetica /= arr.Count();
            geometrica = Math.Pow(geometrica, 1 / arr.Count());
            armonica = arr.Count / armonica;

            Console.WriteLine("Armonica: " + armonica + "; Geometrica: " + geometrica + "; Aritmetica: " + aritmetica);
        }

        private static void ex6(int a, int b)
        {
            Console.WriteLine("ex6");
            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
            for (int nr = a, i = 0; nr <= b; nr++, i++)
            {
                int suma = 0;
                for (int j = 1; j < nr; j++)
                {
                    if (nr % j == 0)
                    {
                        suma += j;
                    }
                }

                if (result.ContainsKey(suma))
                {
                    result[suma].Add(nr);
                }
                else
                {
                    result.Add(suma, new List<int> { nr });
                }
            }
            foreach (KeyValuePair<int, List<int>> kvp in result)
            {
                if (kvp.Value.Count() > 1)
                {
                    string numere = "";
                    foreach (int item in kvp.Value)
                    {
                        numere += item + " ";
                    }
                    Console.WriteLine("suma = {0}, numerele = {1}", kvp.Key, numere);
                }
            }
        }

        private static void ex5(int a, int b)
        {
            Console.WriteLine("ex5");
            string result = "";
            for (int nr = a; nr <= b; nr++)
            {
                int check = 0;
                for (int i = 1; i < nr; i++)
                {
                    if (nr % i == 0)
                    {
                        check += i;
                    }
                }
                if (check == nr)
                {
                    result += nr + " ";
                }
            }
            Console.WriteLine(result);
        }

        private static void ex4(int nr)
        {
            Console.WriteLine("ex4");
            int result = 0;
            for (int i = 1; i < nr; i++)
            {
                if (nr % i == 0)
                {
                    result += i;
                }
            }
            if (result == nr)
            {
                Console.WriteLine(true);
                return;
            }
            Console.WriteLine(false);
        }

        private static void ex3(int i, int j, int k)
        {
            Console.WriteLine("ex3");
            Console.WriteLine(Math.Pow(i, j) % k);
        }

        private static void ex2(string method)
        {
            Console.WriteLine("ex2");
            double result = 0;
            bool a; bool b; int nr1; int nr2;
            switch (method)
            {
                case "adunare":
                    Console.WriteLine("a = ");
                    a = int.TryParse(Console.ReadLine(), out nr1);
                    Console.WriteLine("b = ");
                    b = int.TryParse(Console.ReadLine(), out nr2);
                    result = nr1 + nr2;
                    break;
                case "scadere":
                    Console.WriteLine("a = ");
                    a = int.TryParse(Console.ReadLine(), out nr1);
                    Console.WriteLine("b = ");
                    b = int.TryParse(Console.ReadLine(), out nr2);
                    result = nr1 - nr2;
                    break;
                case "inmultire":
                    Console.WriteLine("a = ");
                    a = int.TryParse(Console.ReadLine(), out nr1);
                    Console.WriteLine("b = ");
                    b = int.TryParse(Console.ReadLine(), out nr2);
                    result = nr1 * nr2;
                    break;
                case "impartire":
                    Console.WriteLine("a = ");
                    a = int.TryParse(Console.ReadLine(), out nr1);
                    Console.WriteLine("b = ");
                    b = int.TryParse(Console.ReadLine(), out nr2);
                    result = nr1 / nr2;
                    break;
                case "radical":
                    Console.WriteLine("nr = ");
                    a = int.TryParse(Console.ReadLine(), out nr1);
                    result = Math.Sqrt(nr1);
                    break;
                case "modul":
                    Console.WriteLine("nr = ");
                    a = int.TryParse(Console.ReadLine(), out nr1);
                    result = Math.Abs(nr1);
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
        }

        private static void ex1(float temp, string convertTo)
        {
            Console.WriteLine("ex1");
            switch (convertTo)
            {
                case "fahrenheit":
                    temp = 9 / 5 * temp + 32;
                    break;
                case "celsius":
                    temp = (temp - 32) * 5 / 9;
                    break;
                default:
                    break;
            }
            Console.WriteLine(temp);
        }
    }
}
