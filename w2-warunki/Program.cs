
using System;
using System.Numerics;
using System.Threading.Channels;

namespace w2_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1(5, 5);
            //ex1(5, 7);
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
            //ex8(80, 71, 0);
            //ex8(80, 22, 33);
            //ex9(41);
            //ex9(-1);
            //ex9(26);
            //ex10(40, 55, 65);
            //ex10(60, 51, 10);
            //ex10(60, 49, 10);
            //ex11(3);
            //ex11(8);
            //ex12(4);
            //ex12(0);
            //ex13();
        }

        private static void ex13()
        {
            //Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem
            int a, b, action; 
            Console.Write("Podaj pierwszą liczbę: ");
            int.TryParse(Console.ReadLine(), out a);            
            Console.Write("Podaj drugą liczbę: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("1.Dodawanie, 2.Odejmowanie, 3.Mnożenie, 4.Dzielenie");
            Console.Write("Podaj numer operacji do wykonania: ");
            int.TryParse(Console.ReadLine(), out action);
            switch (action)
            {
                case 1:
                    Console.WriteLine($"{a}+{b}={a+b}");
                    break;
                case 2:
                    Console.WriteLine($"{a}-{b}={a - b}");
                    break;
                case 3:
                    Console.WriteLine($"{a}*{b}={a * b}");
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                        break;
                    }
                    Console.WriteLine($"{a}/{b}={(float)a / (float)b}");
                    break;
                default:
                    Console.WriteLine("Niepoprawne działanie.");
                    break;
            }
        }

        private static void ex12(int weekday)
        {
            //Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
            switch (weekday)
            {
                case 1:
                    Console.WriteLine("PONIEDZIAŁEK.");
                    break;
                case 2:
                    Console.WriteLine("WTOREK.");
                    break;
                case 3:
                    Console.WriteLine("ŚRODA.");
                    break;
                case 4:
                    Console.WriteLine("CZWARTEK.");
                    break;
                case 5:
                    Console.WriteLine("PIĄTEK.");
                    break;
                case 6:
                    Console.WriteLine("SOBOTA.");
                    break;
                case 7:
                    Console.WriteLine("NIEDZIELA.");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia.");
                    break;
            }
        }

        private static void ex11(int note)
        {
            //Napisz program, który zmieni ocenę ucznia na jej opis
            switch (note)
            {
                case 1:
                    Console.WriteLine("NDST.");
                    break;
                case 2:
                    Console.WriteLine("DOP.");
                    break;
                case 3:
                    Console.WriteLine("DST.");
                    break;
                case 4:
                    Console.WriteLine("DB.");
                    break;
                case 5:
                    Console.WriteLine("BDB.");
                    break;
                case 6:
                    Console.WriteLine("CEL.");
                    break;
                default:
                    Console.WriteLine("Poza skalą ocen.");
                    break;
            }
        }

        private static void ex10(int a, int b, int c)
        {
            //Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
            int[] bokiTrojkata = new int[3] { a, b, c };
            Array.Sort(bokiTrojkata);
            if (bokiTrojkata[2] < bokiTrojkata[0] + bokiTrojkata[1])
            {
                Console.WriteLine("Można zbudować trójkąt.");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta.");
            }

        }

        private static void ex9(int temperature)
        {
            // Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
            switch (temperature)
            {
                case > 40:
                    Console.WriteLine("a weź wyprowadzam się na Alaskę.");
                    break;
                case > 30:
                    Console.WriteLine("zaczyna być słabo, bo gorąco.");
                    break;
                case > 20:
                    Console.WriteLine("w sam raz.");
                    break;
                case > 10:
                    Console.WriteLine("chłodno.");
                    break;
                case > 0:
                    Console.WriteLine("zimno.");
                    break;
                case <= 0:
                    Console.WriteLine("cholernie piździ.");
                    break;
            }
        }
    
        private static void ex8(int mathPoints, int physicsPoints, int chemistryPoints)
        {
            //Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach
            int totalPoints = mathPoints + physicsPoints + chemistryPoints;

            int mathPlusOtherHighestResult = physicsPoints >= chemistryPoints ? mathPoints + physicsPoints : mathPoints + chemistryPoints;
            if ((mathPoints > 70 && physicsPoints > 55 && chemistryPoints > 45 && totalPoints > 180) || mathPlusOtherHighestResult > 150)
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
            // Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
            int a, b, c, max;
            Console.Write("Podaj pierwszą liczbę: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Podaj drugą liczbę: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("Podaj trzecią liczbę: ");
            int.TryParse(Console.ReadLine(), out c);
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
            //Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
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
            // Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta. 
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
            //Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
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

        private static void ex3(int userNumber)
        {
            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
            if (userNumber == 0)
            {
                Console.WriteLine("liczba jest zerem.");
            }
            else if (userNumber > 0)
            {
                Console.WriteLine($"{userNumber} jest liczbą dodatnią.");
            }
            else
            {
                Console.WriteLine($"{userNumber} jest liczbą ujemną.");
            }
        }

        private static void ex2(int userNumber)
        {
            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta. 
            string checkEvenOdd = userNumber % 2 == 0 ? $"{userNumber} jest liczbą parzystą." : $"{userNumber} jest liczbą nieparzystą.";
            Console.WriteLine(checkEvenOdd);
        }

        private static void ex1(int a, int b)
        {
            //Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            string checkIfNumbersAreEqual = a == b ? $"{a} i {b} są równe." : $"{a} i {b} nie są równe.";
            Console.WriteLine(checkIfNumbersAreEqual);
        }
    }
}

