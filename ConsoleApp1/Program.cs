using System;

namespace ConsoleApp1
{
    class Program
    {
        public class kalkulator 
        {
            private int a;
            private int b;

            public kalkulator(int a, int b) 
            {
                this.a = a;
                this.b = b;
            }
            public int dodawanie() 
            {
                return this.a + this.b;
            }

            public int odejmowanie()
            {
                return this.a - this.b;
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Kalkulator 1.0");
            Console.WriteLine("Wybierz dzialanie");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine();
            Console.WriteLine("Podaj numer dzialania i nacisnij enter");
            int dzialanie;
            do
            {
                dzialanie = Convert.ToInt32(Console.ReadLine());
                if (dzialanie == 1)
                {
                    Console.WriteLine("Podaj 1 skladnik i nacisnij enter");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj 2 skladnik i nacisnij enter");
                    int b = Convert.ToInt32(Console.ReadLine());
                    kalkulator kalk = new kalkulator(a, b);
                    Console.WriteLine("Wynik to: {0}", kalk.dodawanie());
                    Console.WriteLine("Nacisnij dowlony przycisk zeby zakonczyc");
                    Console.ReadKey();
                }
                if (dzialanie == 2)
                {
                    Console.WriteLine("Podaj 1 skladnik i nacisnij enter");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj 2 skladnik i nacisnij enter");
                    int b = Convert.ToInt32(Console.ReadLine());
                    kalkulator kalk = new kalkulator(a, b);
                    Console.WriteLine("Wynik to: {0}", kalk.odejmowanie());
                    Console.WriteLine("Nacisnij dowlony przycisk zeby zakonczyc");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Niepoprawny numer dzialania");
                    Console.WriteLine("Podaj numer dzialania i nacisnij enter");
                    
                }
            }
            while (dzialanie > 3 || dzialanie <= 0);

        }
    }
}
