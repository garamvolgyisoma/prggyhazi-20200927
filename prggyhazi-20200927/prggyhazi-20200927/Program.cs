using System;

namespace prggyhazi_20200927
{
    class Program
    {
        public void idobekeres()
        {
            Console.WriteLine(DateTime.Now);
        }
        
        public void gyokvonas()
        {
            Console.Write("Add meg a számot, amelyiknek a gyökét akarod megkapni! (int) ");
            int szam = int.Parse(Console.ReadLine());
            double eredmeny = Math.Sqrt(szam);
            Console.WriteLine(szam + " a gyök alatt = " + eredmeny);
        }

        public void emeles()
        {
            Console.Write("Add meg a számot! (int) ");
            int szam = int.Parse(Console.ReadLine());
            Console.Write("Add meg, hogy hanyadikra szeretnéd emelni! (int) ");
            int hanyadikra = int.Parse(Console.ReadLine());
            int eredmeny = (int)Math.Pow(szam, hanyadikra);
            Console.WriteLine(szam + " a " + hanyadikra + "-on/en = " + eredmeny);
        }

        public void kilepes()
        {

        }

        public void valaszto()
        {
            Console.WriteLine("Válassz funkciót!");
            Console.WriteLine("I - Jelenlegi dátum és idő lekérdezése");
            Console.WriteLine("G - Gyökvonás");
            Console.WriteLine("E - Szám valahanyadikra emelése");
            Console.WriteLine("K - Kilépés a programból");

            var input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.I:
                    {
                        idobekeres();
                        break;
                    }

                case ConsoleKey.G:
                    {
                        gyokvonas();
                        break;
                    }

                case ConsoleKey.E:
                    {
                        emeles();
                        break;
                    }
                case ConsoleKey.K:
                    {
                        kilepes();
                        break;
                    }

                default:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Érvénytelen választás! Válassz újra!");
                        Console.WriteLine();
                        Console.WriteLine();
                        valaszto();
                        break;
                    }
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.valaszto();
        }
    }
}
