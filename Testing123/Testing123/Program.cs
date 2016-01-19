using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimerkit
{
    class softa
    {
        internal struct lukutaulu
        {
            public int luku;
           
        }
        public void Lisaa(ref string summa, int luku)
        {
            summa = summa + luku;
        }
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
            //harjoitus 4
            /*
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
       
    */


            //harjoitus 5
            /*
            int tunti = 3600;
            int syotto;
            Console.WriteLine("Anna sekunnit >");
            syotto = int.Parse(Console.ReadLine());
            Console.WriteLine("Syottamasi sekunnit ovat "+ (syotto / tunti) + " TUNTIA "+ ((syotto % tunti)/60) + " MINUUTTIA " + ((syotto % tunti)%60)  + " SEKUNTIA");
            */

            //harjoitus 6
            /*
            float matka;
            double litra = 7.02;
            double hinta = 1.595;

            Console.WriteLine("Anna Matka >");
            matka = float.Parse(Console.ReadLine());
            
            double kulutus =(litra / 100) * matka;
            string s14 = string.Format("{0:0.00}", (kulutus * hinta));
            Console.WriteLine("Polttoainetta kuluu " + kulutus + " litraa, kustannus " + s14  + " EUROA");
            */
            //Harjoitus 7
            /*
            int vuosi;

            Console.WriteLine("Anna vuosi > ");
            vuosi = int.Parse(Console.ReadLine());
            if (vuosi % 4 == 0)
            {
                if (vuosi % 100 == 0)
                {
                    if (vuosi % 400 == 0)
                    {
                        Console.WriteLine("On karkausvuosi.");
                    }
                    else {
                        Console.WriteLine("Ei ole karkausvuosi.");
                    }
                }
                else {
                    Console.WriteLine("On karkausvuosi.");
                }
            }
            else {
                Console.WriteLine("Ei ole karkausvuosi.");
            }
            */


            //harjoitus 8
            /*
            int luku1, luku2, luku3;
            Console.WriteLine("Anna Luku:");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna Luku:");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna Luku:");
            luku3 = int.Parse(Console.ReadLine());

            int suurin = 0;
            int pienin = 0;
            int keski = 0;
            if (luku1 > luku2 && luku1 > luku3)
            {
                suurin = luku1;

                if (luku2 > luku3)
                {
                    keski = luku2;
                    pienin = luku3;
                }
                //jos keski luku3 pienin luku2
                else if (luku2 < luku3)
                {
                    keski = luku3;
                    pienin = luku2;
                }
            }
            // jos suurin luku3 keskimm„inen luku1 ja pienin luku2 (3)
            else if (luku1 > luku2 && luku1 < luku3)
            {
                suurin = luku3;
                keski = luku1;
                pienin = luku2;
            }
            // jos suurin luku2 keskimm„inen luku1 ja pienin luku3 (4)
            else if (luku1 < luku2 && luku1 > luku3)
            {
                suurin = luku2;
                keski = luku1;
                pienin = luku3;
            }
            //pienin luku1 
            else if (luku1 < luku2 && luku1 < luku3)
            {
                pienin = luku1;
                //jos keski luku2 suurin luku3 (5)
                if (luku2 < luku3)
                {
                    keski = luku2;
                    suurin = luku3;
                }
                //jos keski luku3 suurin luku2 (6)
                else if (luku2 > luku3)
                {
                    keski = luku3;
                    suurin = luku2;
                }
            }
            if (luku1 == luku2 && luku2 == luku3 && luku3 == luku1)
            {
                Console.WriteLine("Suurin luvuista on " + luku1);
            }
            else { 
            Console.WriteLine("Suurin luvuista on " + suurin);
            }
            */

            // harjoitus 9
            /*
            int luku = 1;
            int summa = 0;

            lukutaulu[] lukuja = new lukutaulu[100];
            while (luku > 0)
            {
                Console.Write("Anna Luku >");
                luku = int.Parse(Console.ReadLine());
                summa = luku + summa;
            }

            Console.WriteLine("Lukujen summa " + summa);
            ///////////////
            */

            int[] luku = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            Console.WriteLine();
            for (int i = 0;i < 9; i++)
            {
                Console.Write(luku[i]);
                if (luku[i] % 2 == 0)
                {
                    
                    Console.Write(" HEP ");
                }
                else
                {
                 
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
        }
}
