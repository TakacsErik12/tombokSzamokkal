namespace tombokSzamokkal
{
    internal class Program
    {

        static int[] tomb = new int[15];

        static Random r = new Random();
        static void Feltolt()   
        {
            for (int i = 0 ; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);
            }
            foreach (int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void OsszegzesTetel()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine("A tömb elemeinek összege: " + osszeg);
        }

        static void MegszamlalasTetel()
        {
            int negativSzamok = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    negativSzamok++;
                }
            }
            Console.WriteLine($"A tömb negatív elemeinek száma: {negativSzamok}");
        }

        static void EldontesTetel()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0");
            }
            else
            {
                Console.WriteLine("Nincs 0");
            }
        }
        static void KeresesTetel()
        {
            int keresett = 0; // van e 0, ha van, akkor az indexét is írjuk ki
            int i = 0;
            while (i < tomb.Length && tomb[i] != keresett)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine($"A keresett szám az {i}. indexen van.");
            }
            else
            {
                Console.WriteLine("Nincs a tömbben a keresett szám.");
            }
        }
        static void KivalasztasTetel()
        {
            //tudjuk, hogy a tömbben van a keresett elem, keressük meg az indexét
            tomb[8] = 10;
            int i = 0;
            while (tomb[i] != 10)
            {
                i++;
            }
            Console.WriteLine($"A keresett szám az {i+1}. helyen van.");
        }
        static void Main(string[] args)
        {
            Feltolt();
            OsszegzesTetel();
            MegszamlalasTetel();
            EldontesTetel();
        }
    }
}
