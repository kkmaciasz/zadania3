using System.Security.Cryptography.X509Certificates;

namespace cwiczenia3
{
    class Program
    {
        static void zad41_srednia()
        {
            int suma = 0;
            int ocena;
            int licznik = 0;
            do
            {
                Console.Write("Podaj ocenę: ");
                ocena = Convert.ToInt32(Console.ReadLine());
                suma += ocena;
                licznik += 1;
            } while (ocena != -1);
            if (licznik > 0)
            {
                double srednia = suma / (double)licznik;
                Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
            }
            else
            {
                Console.WriteLine("Brak danych do obliczenia średniej");
            }
        }

        static void zad42_lokata()
        {
            Console.Write("Podaj kwotę: ");
            double Y = Double.Parse(Console.ReadLine());
            double X = 2 * Y;
            int lata = 0;
            while (Y < X)
            {
                Y = Y + (0.06 * Y);
                lata += 1;
            }
            Console.WriteLine($"Wartość inwestycji po {lata} latach: {Y:N}");
        }

        static void zad43_los()
        {
            Random rnd = new Random();
            int licznik = 1;
            int x = rnd.Next(2, 10);
            Console.WriteLine("Zgadnij liczbę: ");
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a < x)
                {
                    Console.WriteLine("Za mało!");
                    licznik++;
                }
                else if (a > x)
                {
                    Console.WriteLine("Za dużo!");
                    licznik++;
                }
                else
                {
                    Console.Write($"Dobrze! Zgadłeś za {licznik} razem");
                    break;
                }
            }

        }
        static void zad44_dwojka()
        {
            Console.WriteLine("Podaj liczbę: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            while (x % 2 == 0)
            {
                x = x / 2;
                n++;
            }
            if (x == 1)
            {
                Console.WriteLine($"Podana liczba to 2^{n}");
            }
            else
            {
                Console.WriteLine($"Podanej liczby nie można przedstawić w postaci potęgi liczby 2");
            }
            
        }
        static void zad45_nwd()
        {
            Console.Write("Podaj liczbę a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.Write($"NWD wynosi {a}");
        }

        static void zad46_pi()
        {
            Console.Write("Podaj dokładność d: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double pi = 0, aktualny_ulamek = 1D;
            double i = 1D;
            int n = 0;
            while (aktualny_ulamek > d)
            {
                if (n % 2 == 0)
                {
                    pi += 1 / i;
                }
                else
                {
                    pi -= 1 / i;
                }
                i += 2;
                n++;
                aktualny_ulamek = 1 / i;
            }
            Console.WriteLine($"Liczba pi z przybliżeniem do {d} to: {pi * 4}");
        }

        static void zad47_doskonala()
        {
            Console.WriteLine("Podaj liczbę: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            int i = 1;
            Console.WriteLine($"Dzielniki liczby {a}:");
            while (suma<a)
            {
                if (a % i == 0)
                {
                    suma = suma + i;
                    Console.WriteLine($"{i}");
                }
                i++;
            }
            Console.WriteLine($"Suma powyższych dzielników = {suma}");
            if (suma == a)
            {
                Console.Write($"{suma} = {a} zatem liczba {a} jest doskonała");
            }
            else
            {
                Console.Write($"{suma} =/= {a} zatem iczba {a} nie jest doskonała");
            }
        }

        static void Main(string[] args)
        {
            //zad41_srednia();
            //zad42_lokata();
            //zad43_los();
            //zad44_dwojka();
            //zad45_nwd();
            //zad46_pi();
            //zad47_doskonala();
        }
    }
}
