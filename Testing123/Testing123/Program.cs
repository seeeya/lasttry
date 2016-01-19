using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimerkit
{
    class softa
    {
        static void Main(string[] args)
        {

            //harjoitus1
            /*
            int luku;
            string lugu = "JE";
            bool jebou =true;
            Console.WriteLine("Syota luku >");
            luku = int.Parse(Console.ReadLine());
            switch(luku)
            {
                case 1:
                    lugu = "Yksi";
                    break;
                case 2:
                    lugu = "Kaksi";
                    break;
                case 3:
                    lugu = "Kolme";
                    break;
                default:
                    jebou = false;
                    break;

            }
            if(jebou != false) { 
            Console.WriteLine("Annoit Luvun "+ lugu);
        }
            else
            {
                Console.WriteLine("Luku ei kelpaa!");
            }
        
        */
            //harjoitus 2
            /*
            int numero = 0, pisteet;

            Console.Write("Syötä Pistemäärä > ");
            pisteet = int.Parse(Console.ReadLine());

            if (pisteet == 0 || pisteet == 1)
            {
                numero = 0;
            }
            else if (pisteet == 2 || pisteet == 3)
            {
                numero = 1;

            }
            else if (pisteet == 4 || pisteet == 5)
            {
                numero = 2;

            }
            else if (pisteet == 6 || pisteet == 7)
            {
                numero = 3;

            }
            else if (pisteet == 8 || pisteet == 9)
            {
                numero = 4;
            }

            else if (pisteet >= 10 || pisteet <= 12)
            {
                numero = 5;
            }

            Console.WriteLine("\nKoulunumero on " + numero + "\n");

            Console.ReadLine();

    */
            //Harjoitus 3
            /*
            int luku1;
            int luku2;
            int luku3;
            Console.WriteLine("Syötä kolme lukua. Syötä ensimmäinen >");
            luku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä luku 2 >");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä luku 3 >");
            luku3 = int.Parse(Console.ReadLine());

            int summa = luku1 + luku2 + luku3;
            int ka = summa / 3;

            Console.WriteLine("Lukujen "+luku2 + " " +luku2 + " "+luku3+" summa on "+ summa + " ja keskiarvo on "+ka);
            */
            int ika;
            Console.WriteLine("Syötä ikäsi >");
            ika = int.Parse(Console.ReadLine());
            string jebouu = null;
            if (17 < ika && ika < 65)
            {
                jebouu = "Täysi-ikäinen";
            }

            else if (ika < 18)
            {
                jebouu = "Alaikäinen";
            }
            else
            {
                jebouu = "Seniori";

            }
            Console.WriteLine("Olet " + ika + " vuotta joten olet " + jebouu);
        }
    }
}
