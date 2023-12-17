
using System.Numerics;
using System.Threading.Channels;

namespace w2_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2(15);
            //ex2(16);
            //ex3(14);
            //ex3(-7);
            //ex3(0);
            //ex4(2016);
            //ex4(1999);
            //ex4(2000);
            //ex4(2002);
            //ex4(2023);
            //ex5(16);
            //ex5(44);
            //ex5(22);
            //ex5(33);
            //ex6(122);
            //ex6(124);
            //ex6(183);
            //ex6(84);
            //ex6(284);
            //ex7();
            ex8(33, 55, 95);
        }

        private static void ex8(int mathPoints, int physicsPoints, int chemistryPoints)
        {
            int totalPoints = mathPoints + physicsPoints + chemistryPoints;
            int mathPlusOtherHighestResult;

            mathPlusOtherHighestResult = physicsPoints >= chemistryPoints ? mathPoints + physicsPoints : mathPoints + chemistryPoints;
            Console.WriteLine($"total: {totalPoints}");
            Console.WriteLine($"math+: {mathPlusOtherHighestResult}");

            if ((mathPoints > 70 || physicsPoints > 55 || chemistryPoints > 45 || totalPoints > 180) || mathPlusOtherHighestResult > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }
        }

        private static void ex7()
        {
            int a, b, c, max;
            Console.Out.Write("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Out.Write("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out b);
            Console.Out.Write("Podaj trzecią liczbę: ");
            Int32.TryParse(Console.ReadLine(), out c);
            max = a;
            if (b > max)
            {
                max = b;
            }
            else if (c > max)
            {
                max = c;
            }
            Console.WriteLine($"Największa z podanych liczb to {max}.");
        }

        private static void ex6(int height)
        {
            switch (height)
            {
                case >= (int)Size.XXXL:
                    Console.WriteLine($"Nosisz rozmiar {Size.XXXL}.");
                    break;
                case >= (int)Size.XXL:
                    Console.WriteLine($"Nosisz rozmiar {Size.XXL}.");
                    break;
                case >= (int)Size.XL:
                    Console.WriteLine($"Nosisz rozmiar {Size.XL}.");
                    break;
                case >= (int)Size.L:
                    Console.WriteLine($"Nosisz rozmiar {Size.L}.");
                    break;
                case >= (int)Size.M:
                    Console.WriteLine($"Nosisz rozmiar {Size.M}.");
                    break;
                case >= (int)Size.S:
                    Console.WriteLine($"Nosisz rozmiar {Size.S}.");
                    break;
                default:
                    Console.WriteLine($"Nosisz rozmiar Baby.");
                    break;
            }
        }
        public enum Size
        {
            //size - from, cm
            S = 98,
            M = 124,
            L = 156,
            XL = 180,
            XXL = 200,
            XXXL = 220
        }
        private static void ex5(int age)
        {
            const int PRESIDENT_MIN_AGE = 35;
            const int SENATOR_MIN_AGE = 30;
            const int MEMBER_OF_PARLIAMENT_MIN_AGE = 21;

            switch (age)
            {
                case >= PRESIDENT_MIN_AGE:
                    Console.WriteLine("Możesz zostać posłem, senatorem lub prezydentem.");
                    break;
                case >= SENATOR_MIN_AGE:
                    Console.WriteLine("Możesz zostać posłem lub senatorem.");
                    break;
                case >= MEMBER_OF_PARLIAMENT_MIN_AGE:
                    Console.WriteLine("Możesz zostać posłem.");
                    break;
                default:
                    Console.WriteLine("Nie możesz kandydować.");
                    break;
            }

        }

        private static void ex4(int year)
        {
            bool isLeapYear = false;
            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    isLeapYear = true;
                }
                else if (year % 400 == 0)
                {
                    isLeapYear = true;
                }
            }
            var check = isLeapYear ? $"{year} jest rokiem przestępnym." : $"{year} nie jest rokiem przestępnym.";
            Console.WriteLine(check);
        }

        private static void ex3(int v)
        {
            if (v == 0)
            {
                Console.WriteLine("liczba jest zerem.");
            }
            else if (v > 0)
            {
                Console.WriteLine($"{v} jest liczbą dodatnią.");
            }
            else
            {
                Console.WriteLine($"{v} jest liczbą ujemną.");
            }
        }

        private static void ex2(int v)
        {
            var check = v % 2 == 0 ? $"{v} jest liczbą parzystą." : $"{v} jest liczbą nieparzystą.";
            Console.WriteLine(check);
        }

        private static void ex1()
        {
            int a = 5, b = 5;
            var check = a == b ? $"{a} i {b} są równe." : $"{a} i {b} nie są równe.";
            Console.WriteLine(check);
        }
    }
}
