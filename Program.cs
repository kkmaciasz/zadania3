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

        static void zad43_los()
        {
            Random rnd = new Random();
            int licznik = 1;
            int x = rnd.Next(2, 10);
            Console.WriteLine("Zgadnij liczbę: ");
            while(true)
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

        static void Main(string[] args)
        {
            //zad41_srednia();
            //zad42_lokata();
            //zad43_los();
            //zad45_nwd();
        }
    }
}
