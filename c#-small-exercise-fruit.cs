using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obstliste
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Obst> lo = new List<Obst>();

                lo.Add(new Obst("Gurke", 2.50, 2, 1));
                lo.Add(new Obst("Tomate", 2.60, 2, 1));
                lo.Add(new Obst("Kartoffel", 1.75, 2, 1));
                lo.Add(new Obst("Zucchini", 1.50, 2, 1));
                lo.Add(new Obst("Apfel", 1.50, 1, 2));
                lo.Add(new Obst("Banane", 1.75, 1, 2));
                lo.Add(new Obst("Erdbeeren", 1.30, 1, 2));
                lo.Add(new Obst("Kirschen", 1.40, 1, 2));

                for (int i = 0; i < lo.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + lo[i].getName());
                }

                Console.WriteLine("Bitte wählen Sie das gewünschte Produkt aus");
                int eingabe = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine("Ihre Auswahl: ");

                if (lo[eingabe].getObst() == 1)
                {
                    Console.WriteLine("Name: " + lo[eingabe].getName() + "\nPreis: " + lo[eingabe].getPreis() + "\nKategorie: Obst");
                }
                else
                {
                    Console.WriteLine("Name: " + lo[eingabe].getName() + "\nPreis: " + lo[eingabe].getPreis() + "\nKategorie: Gemüse");
                }
            }
            catch (Exception ex)
            {
                Console.Write("Fehler aufgetreten: ");
                Console.WriteLine(ex.Message);

            }
            finally {
                Console.WriteLine("Programm wird geschlossen.");
            }
            Console.ReadKey();
        }
    }
}
