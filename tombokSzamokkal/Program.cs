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
        static void Main(string[] args)
        {
            Feltolt();
            OsszegzesTetel();
            MegszamlalasTetel();
        }
    }
}
