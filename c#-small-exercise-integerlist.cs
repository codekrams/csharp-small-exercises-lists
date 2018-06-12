using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerListe
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe = 0;
            List<int> li = new List<int>();
            listeFuellen(li);

            try
            {
                do
                {
                    int auswahl = menueAnzeigen();
                    aufgabeAusfuehren(auswahl, li);

                    Console.WriteLine("Kontrollausgabe:");
                    foreach (int l in li)
                    {
                        Console.WriteLine(l);
                    }
                    Console.WriteLine("Möchten Sie weitere Rechenaufgaben ausführen? 1 für Ja, 0 für Beenden");
                    eingabe = Convert.ToInt32(Console.ReadLine());

                } while (eingabe != 0);
            }
            catch (Exception ex)
            {
                Console.Write("Fehler aufgetreten: ");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Programm wird geschlossen.");
            }


            Console.ReadKey();
        }


        private static void listeFuellen(List<int> liste) {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                liste.Add(r.Next(1, 101));
            }
        }


        private static int menueAnzeigen() {
            
            Console.WriteLine("Was möchten Sie tun? \n1-Anzahl der Elemente ausgeben\n2-Kleinste Zahl in der Liste \n3-Größte Zahl in der Liste \n4-Summe");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            return eingabe;
        }

        private static void aufgabeAusfuehren(int x, List<int> liste) {

            if (x == 1) {
                Console.WriteLine("Anzahl der Elemente: " + liste.Count);
            }

            else if (x == 2)
            {
                Console.WriteLine("Kleinste Zahl: " + liste.Min());
            }

            else if (x == 3)
            {
                Console.WriteLine("Größte Zahl: " + liste.Max());
            }

            else if (x == 4)
            {
                Console.WriteLine("Summe: " + liste.Sum());
            }

        }
    }
}
